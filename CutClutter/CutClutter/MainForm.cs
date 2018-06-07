using CutClutter.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CutClutter
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			ShowIcon = false;

			m_CopyModeLeft = Settings.Default.CopyModeLeft;
			m_CopyModeRight = Settings.Default.CopyModeRight;
			m_AllFiles = Settings.Default.AllFiles;

			ChangeButtonStates();

			Text = $"{Application.ProductName} v{Application.ProductVersion}";
			KeyPress += MainForm_KeyPress;
			FormClosed += MainForm_FormClosed;
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.CopyModeLeft = m_CopyModeLeft;
			Settings.Default.CopyModeRight = m_CopyModeRight;
			Settings.Default.AllFiles = m_AllFiles;
			Settings.Default.Save();
		}

		private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch(e.KeyChar)
			{
				case 's':
					ActionNextImage();
					break;
				case 'a':
					ActionMoveFile(m_LeftPath, m_CopyModeLeft);
					break;
				case 'd':
					ActionMoveFile(m_RightPath, m_CopyModeRight);
					break;
			}
		}

		private string m_SourcePath = String.Empty;
		private string m_LeftPath = String.Empty;
		private string m_RightPath = String.Empty;

		private string SelectFolder(string lastFolder)
		{
			CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog()
			{
				IsFolderPicker = true,
				InitialDirectory = String.IsNullOrWhiteSpace(lastFolder) ? Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) : lastFolder,
				NavigateToShortcut = true,
				Multiselect = false,
			};

			var result = openFileDialog.ShowDialog();
			if (result == CommonFileDialogResult.Ok)
			{
				if (!Directory.Exists(openFileDialog.FileName))
				{
					return String.Empty;
				}

				return openFileDialog.FileName;
			}

			return String.Empty;
		}

		private void ActionNextImage()
		{
			pictureBoxView.Image?.Dispose();
			pictureBoxView.Image = null;
			SelectNextFile();
			ChangeButtonStates();
		}

		private void ButtonSource_Click(object sender, EventArgs e)
		{
			m_SourcePath = SelectFolder(Settings.Default.LastDirectorySource);
			Settings.Default.LastDirectorySource = m_SourcePath;
			ChangeButtonStates();
			BeginContest();
		}

		private IEnumerable<string> currentEnumeration;
		private IEnumerator<string> currentEnumerator;
		private string currentFile = String.Empty;

		private void BeginContest()
		{
			if (String.IsNullOrWhiteSpace(m_SourcePath))
			{
				return;
			}

			currentEnumeration = Directory.EnumerateFiles(m_SourcePath);
			currentEnumerator = currentEnumeration.GetEnumerator();

			SelectNextFile();
			ChangeButtonStates();
		}

		private bool SelectNextFile()
		{
			while (currentEnumerator.MoveNext())
			{
				if (!extensions.Contains(Path.GetExtension(currentEnumerator.Current).ToLower()))
				{
					if (m_AllFiles)
					{
						Icon icon = SystemIcons.WinLogo;
						icon = Icon.ExtractAssociatedIcon(currentEnumerator.Current);

						var bmpFile = new Bitmap(pictureBoxView.Width, pictureBoxView.Height);
						{
							var g = Graphics.FromImage(bmpFile);
							var rectIcon = new Rectangle(
								(pictureBoxView.Width / 2) - (icon.Width / 2),
								(pictureBoxView.Height / 2) - (icon.Height * 2),
								icon.Width, icon.Height);
							g.DrawIconUnstretched(icon, rectIcon);
							g.Flush();
						}
						ApplyTextToCenter(currentEnumerator.Current, FontStyle.Bold, FontFamily.GenericMonospace.Name, 12, ref bmpFile);

						pictureBoxView.Image = bmpFile;
						currentFile = currentEnumerator.Current;
						return true;
					}
					continue;
				}

				pictureBoxView.Image = new Bitmap(currentEnumerator.Current);
				currentFile = currentEnumerator.Current;
				return true;
			}

			pictureBoxView.Image?.Dispose();

			var rectf = new RectangleF(0, 0, pictureBoxView.Width, pictureBoxView.Height);
			var bmp = new Bitmap(pictureBoxView.Width, pictureBoxView.Height);
			ApplyTextToCenter("End of folder - no more matching files", FontStyle.Bold | FontStyle.Underline, FontFamily.GenericMonospace.Name, 12, ref bmp);
			pictureBoxView.Image = bmp;
			currentFile = String.Empty;
			labelInfo.Text = "End of folder - no more matching files";
			return false;
		}

		private void ApplyTextToCenter(string text, FontStyle style, string fontName, float emSize, ref Bitmap targetBmp)
		{
			var g = Graphics.FromImage(targetBmp);
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			StringFormat stringFormat = new StringFormat()
			{
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center,
			};
			var unit = GraphicsUnit.Pixel;
			g.DrawString(text, new Font(fontName, emSize, style), Brushes.Black, targetBmp.GetBounds(ref unit), stringFormat);
			g.Flush();
		}

		private readonly HashSet<string> extensions = new HashSet<string>()
		{
			".jpg",
			".gif",
			".jpeg",
			".bmp",
			".wmf",
			".png"
		};

		private void ButtonRightBin_Click(object sender, EventArgs e)
		{
			m_RightPath = SelectFolder(Settings.Default.LastDirectoryRight);
			Settings.Default.LastDirectoryRight = m_RightPath;
			ChangeButtonStates();
		}

		private void ButtonLeftBin_Click(object sender, EventArgs e)
		{
			m_LeftPath = SelectFolder(Settings.Default.LastDirectoryLeft);
			Settings.Default.LastDirectoryLeft = m_LeftPath;
			ChangeButtonStates();
		}

		private bool m_CopyModeLeft = false;
		private bool m_CopyModeRight = false;

		private void ChangeButtonStates()
		{
			//buttonRightMove.Enabled = (m_RightPath != String.Empty) && (currentFile != String.Empty);
			//buttonLeftMove.Enabled = (m_LeftPath != String.Empty) && (currentFile != String.Empty);
			//buttonSourceNoMove.Enabled = (m_SourcePath != String.Empty) && (currentFile != String.Empty);
			labelCurrentFile.Text = currentFile;
			labelLeftBin.Text = m_LeftPath;
			labelRightBin.Text = m_RightPath;
			advancedToolStripMenuItem.Text =  m_AllFiles ? "All files" : "Images only";
			imagesonlyToolStripMenuItem.Enabled = m_AllFiles;
			allfilesToolStripMenuItem.Enabled = !m_AllFiles;

			m_CopyModeLeft = checkBoxLeft.Checked;
			m_CopyModeRight = checkBoxRight.Checked;
		}

		private void MoveFile(string targetPath, bool copy)
		{
			var targetFile = Path.Combine(targetPath, Path.GetFileName(currentFile));
			if (copy)
			{
				File.Copy(currentFile, targetFile);
				labelInfo.Text = $"{currentFile} -(Copy)-> {targetFile}";
			}
			else
			{
				// TODO: try catch
				File.Move(currentFile, targetFile);
				labelInfo.Text = $"{currentFile} -(Move)-> {targetFile}";
			}
		}

		private void ActionMoveFile(string target, bool copy)
		{
			if ((target != String.Empty) && (currentFile != String.Empty))
			{
				pictureBoxView.Image?.Dispose();
				pictureBoxView.Image = null;

				MoveFile(target, copy);
				SelectNextFile();
				ChangeButtonStates();
			}
		}

		private void PictureBoxView_MouseClick(object sender, MouseEventArgs e)
		{
			var point = new Point(e.X, e.Y);
			Rectangle rect;

			if ((m_LeftPath != String.Empty) && (currentFile != String.Empty))
			{
				rect = new Rectangle(buttonLeftBin.Bounds.X, pictureBoxView.Bounds.Y, buttonLeftBin.Bounds.Width, pictureBoxView.Bounds.Height);
				if (rect.Contains(point))
				{
					ActionMoveFile(m_LeftPath, m_CopyModeLeft);
					return;
				}
			}

			if ((m_RightPath != String.Empty) && (currentFile != String.Empty))
			{
				rect = new Rectangle(buttonRightBin.Bounds.X, pictureBoxView.Bounds.Y, buttonRightBin.Bounds.Width, pictureBoxView.Bounds.Height);
				if (rect.Contains(point))
				{
					ActionMoveFile(m_RightPath, m_CopyModeRight);
					return;
				}
			}

			if ((m_SourcePath != String.Empty) && (currentFile != String.Empty))
			{
				rect = new Rectangle(buttonSource.Bounds.X, pictureBoxView.Bounds.Y, buttonSource.Bounds.Width, pictureBoxView.Bounds.Height);
				if (rect.Contains(point))
				{
					ActionNextImage();
					return;
				}
			}
		}

		private void CheckBoxLeft_CheckedChanged(object sender, EventArgs e)
		{
			ChangeButtonStates();
		}

		private void CheckBoxRight_CheckedChanged(object sender, EventArgs e)
		{
			ChangeButtonStates();
		}

		private bool m_AllFiles = false;

		private void ImagesonlyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_AllFiles = false;
			ChangeButtonStates();
		}

		private void AllfilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			m_AllFiles = true;
			ChangeButtonStates();
		}
	}
}
