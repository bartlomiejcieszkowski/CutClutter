namespace PictureSortingBin
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonLeftBin = new System.Windows.Forms.Button();
			this.buttonRightBin = new System.Windows.Forms.Button();
			this.labelCurrentFile = new System.Windows.Forms.Label();
			this.labelRightBin = new System.Windows.Forms.Label();
			this.labelLeftBin = new System.Windows.Forms.Label();
			this.buttonSource = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imagesonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBoxView = new System.Windows.Forms.PictureBox();
			this.checkBoxLeft = new System.Windows.Forms.CheckBox();
			this.checkBoxRight = new System.Windows.Forms.CheckBox();
			this.labelInfo = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.buttonLeftBin, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonRightBin, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelCurrentFile, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelRightBin, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelLeftBin, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.buttonSource, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBoxLeft, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.checkBoxRight, 5, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelInfo, 2, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// buttonLeftBin
			// 
			this.buttonLeftBin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonLeftBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLeftBin.Location = new System.Drawing.Point(0, 0);
			this.buttonLeftBin.Margin = new System.Windows.Forms.Padding(0);
			this.buttonLeftBin.Name = "buttonLeftBin";
			this.buttonLeftBin.Size = new System.Drawing.Size(156, 40);
			this.buttonLeftBin.TabIndex = 3;
			this.buttonLeftBin.Text = "Select left bin";
			this.buttonLeftBin.UseVisualStyleBackColor = true;
			this.buttonLeftBin.Click += new System.EventHandler(this.buttonLeftBin_Click);
			// 
			// buttonRightBin
			// 
			this.buttonRightBin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonRightBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRightBin.Location = new System.Drawing.Point(624, 0);
			this.buttonRightBin.Margin = new System.Windows.Forms.Padding(0);
			this.buttonRightBin.Name = "buttonRightBin";
			this.buttonRightBin.Size = new System.Drawing.Size(160, 40);
			this.buttonRightBin.TabIndex = 4;
			this.buttonRightBin.Text = "Select right bin";
			this.buttonRightBin.UseVisualStyleBackColor = true;
			this.buttonRightBin.Click += new System.EventHandler(this.buttonRightBin_Click);
			// 
			// labelCurrentFile
			// 
			this.labelCurrentFile.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelCurrentFile, 2);
			this.labelCurrentFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCurrentFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelCurrentFile.Location = new System.Drawing.Point(393, 521);
			this.labelCurrentFile.Name = "labelCurrentFile";
			this.labelCurrentFile.Size = new System.Drawing.Size(228, 20);
			this.labelCurrentFile.TabIndex = 6;
			this.labelCurrentFile.Text = "None";
			this.labelCurrentFile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// labelRightBin
			// 
			this.labelRightBin.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelRightBin, 2);
			this.labelRightBin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRightBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelRightBin.Location = new System.Drawing.Point(549, 541);
			this.labelRightBin.Name = "labelRightBin";
			this.labelRightBin.Size = new System.Drawing.Size(232, 20);
			this.labelRightBin.TabIndex = 7;
			this.labelRightBin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// labelLeftBin
			// 
			this.labelLeftBin.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelLeftBin, 2);
			this.labelLeftBin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLeftBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelLeftBin.Location = new System.Drawing.Point(3, 541);
			this.labelLeftBin.Name = "labelLeftBin";
			this.labelLeftBin.Size = new System.Drawing.Size(228, 20);
			this.labelLeftBin.TabIndex = 8;
			this.labelLeftBin.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// buttonSource
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.buttonSource, 4);
			this.buttonSource.ContextMenuStrip = this.contextMenuStrip1;
			this.buttonSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSource.Location = new System.Drawing.Point(156, 0);
			this.buttonSource.Margin = new System.Windows.Forms.Padding(0);
			this.buttonSource.Name = "buttonSource";
			this.buttonSource.Size = new System.Drawing.Size(468, 40);
			this.buttonSource.TabIndex = 9;
			this.buttonSource.Text = "Select source";
			this.buttonSource.UseVisualStyleBackColor = true;
			this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
			// 
			// advancedToolStripMenuItem
			// 
			this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagesonlyToolStripMenuItem,
            this.allfilesToolStripMenuItem});
			this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
			this.advancedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.advancedToolStripMenuItem.Text = "Advanced";
			// 
			// imagesonlyToolStripMenuItem
			// 
			this.imagesonlyToolStripMenuItem.Name = "imagesonlyToolStripMenuItem";
			this.imagesonlyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.imagesonlyToolStripMenuItem.Text = "Images only";
			this.imagesonlyToolStripMenuItem.Click += new System.EventHandler(this.imagesonlyToolStripMenuItem_Click);
			// 
			// allfilesToolStripMenuItem
			// 
			this.allfilesToolStripMenuItem.Name = "allfilesToolStripMenuItem";
			this.allfilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.allfilesToolStripMenuItem.Text = "All files";
			this.allfilesToolStripMenuItem.Click += new System.EventHandler(this.allfilesToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel1, 6);
			this.panel1.Controls.Add(this.pictureBoxView);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 481);
			this.panel1.TabIndex = 10;
			// 
			// pictureBoxView
			// 
			this.pictureBoxView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxView.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxView.Name = "pictureBoxView";
			this.pictureBoxView.Size = new System.Drawing.Size(784, 481);
			this.pictureBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxView.TabIndex = 0;
			this.pictureBoxView.TabStop = false;
			this.pictureBoxView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxView_MouseClick);
			// 
			// checkBoxLeft
			// 
			this.checkBoxLeft.AutoSize = true;
			this.checkBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBoxLeft.Location = new System.Drawing.Point(0, 521);
			this.checkBoxLeft.Margin = new System.Windows.Forms.Padding(0);
			this.checkBoxLeft.Name = "checkBoxLeft";
			this.checkBoxLeft.Size = new System.Drawing.Size(156, 20);
			this.checkBoxLeft.TabIndex = 11;
			this.checkBoxLeft.Text = "Copy only";
			this.checkBoxLeft.UseVisualStyleBackColor = true;
			this.checkBoxLeft.CheckedChanged += new System.EventHandler(this.checkBoxLeft_CheckedChanged);
			// 
			// checkBoxRight
			// 
			this.checkBoxRight.AutoSize = true;
			this.checkBoxRight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBoxRight.Location = new System.Drawing.Point(624, 521);
			this.checkBoxRight.Margin = new System.Windows.Forms.Padding(0);
			this.checkBoxRight.Name = "checkBoxRight";
			this.checkBoxRight.Size = new System.Drawing.Size(160, 20);
			this.checkBoxRight.TabIndex = 12;
			this.checkBoxRight.Text = "Copy only";
			this.checkBoxRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxRight.UseVisualStyleBackColor = true;
			this.checkBoxRight.CheckedChanged += new System.EventHandler(this.checkBoxRight_CheckedChanged);
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelInfo, 2);
			this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInfo.Location = new System.Drawing.Point(237, 541);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(306, 20);
			this.labelInfo.TabIndex = 13;
			this.labelInfo.Text = "label1";
			this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBoxView;
		private System.Windows.Forms.Button buttonLeftBin;
		private System.Windows.Forms.Button buttonRightBin;
		private System.Windows.Forms.Label labelCurrentFile;
		private System.Windows.Forms.Label labelRightBin;
		private System.Windows.Forms.Label labelLeftBin;
		private System.Windows.Forms.Button buttonSource;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBoxLeft;
		private System.Windows.Forms.CheckBox checkBoxRight;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imagesonlyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allfilesToolStripMenuItem;
	}
}

