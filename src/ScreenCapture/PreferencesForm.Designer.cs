namespace RSTL.ScreenCapture
{
	partial class PreferencesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
			this.notify = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.screenShotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectRegionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.preferencesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageFormat = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.chooseFolderButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.applyShortcutButton = new System.Windows.Forms.Button();
			this.shortcut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.saveToClipboard = new System.Windows.Forms.RadioButton();
			this.autoSave = new System.Windows.Forms.RadioButton();
			this.askWhereToSave = new System.Windows.Forms.RadioButton();
			this.saveFolderPath = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.linkLabel = new System.Windows.Forms.LinkLabel();
			this.startAutomatically = new System.Windows.Forms.CheckBox();
			this.checkUpdates = new System.Windows.Forms.CheckBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.contextMenu.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// notify
			// 
			this.notify.BalloonTipText = "Screen Capture";
			this.notify.BalloonTipTitle = "Message";
			this.notify.ContextMenuStrip = this.contextMenu;
			this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
			this.notify.Text = "Screen Capture";
			this.notify.Visible = true;
			this.notify.DoubleClick += new System.EventHandler(this.notify_DoubleClick);
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.screenShotMenuItem,
            this.selectRegionMenuItem,
            this.toolStripSeparator2,
            this.preferencesMenuItem,
            this.aboutMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(153, 148);
			// 
			// screenShotMenuItem
			// 
			this.screenShotMenuItem.Name = "screenShotMenuItem";
			this.screenShotMenuItem.Size = new System.Drawing.Size(152, 22);
			this.screenShotMenuItem.Text = "Print screen!";
			this.screenShotMenuItem.Click += new System.EventHandler(this.screenShotMenuItem_Click);
			// 
			// selectRegionMenuItem
			// 
			this.selectRegionMenuItem.Name = "selectRegionMenuItem";
			this.selectRegionMenuItem.Size = new System.Drawing.Size(152, 22);
			this.selectRegionMenuItem.Text = "Select region...";
			this.selectRegionMenuItem.Click += new System.EventHandler(this.selectRegionMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
			// 
			// preferencesMenuItem
			// 
			this.preferencesMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.preferencesMenuItem.Name = "preferencesMenuItem";
			this.preferencesMenuItem.Size = new System.Drawing.Size(152, 22);
			this.preferencesMenuItem.Text = "Preferences";
			this.preferencesMenuItem.Click += new System.EventHandler(this.preferencesMenuItem_Click);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutMenuItem.Text = "About";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitMenuItem.Text = "Exit";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// imageFormat
			// 
			this.imageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.imageFormat.FormattingEnabled = true;
			this.imageFormat.Items.AddRange(new object[] {
            "JPG",
            "PNG"});
			this.imageFormat.Location = new System.Drawing.Point(80, 24);
			this.imageFormat.Name = "imageFormat";
			this.imageFormat.Size = new System.Drawing.Size(50, 21);
			this.imageFormat.TabIndex = 6;
			this.imageFormat.SelectedIndexChanged += new System.EventHandler(this.imageFormat_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Format:";
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new System.Drawing.Point(187, 382);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 10;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// chooseFolderButton
			// 
			this.chooseFolderButton.Location = new System.Drawing.Point(154, 64);
			this.chooseFolderButton.Name = "chooseFolderButton";
			this.chooseFolderButton.Size = new System.Drawing.Size(31, 23);
			this.chooseFolderButton.TabIndex = 11;
			this.chooseFolderButton.Text = "...";
			this.chooseFolderButton.UseVisualStyleBackColor = true;
			this.chooseFolderButton.Click += new System.EventHandler(this.chooseFolderButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.applyShortcutButton);
			this.groupBox1.Controls.Add(this.shortcut);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 108);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Shortcut";
			// 
			// applyShortcutButton
			// 
			this.applyShortcutButton.Location = new System.Drawing.Point(171, 72);
			this.applyShortcutButton.Name = "applyShortcutButton";
			this.applyShortcutButton.Size = new System.Drawing.Size(63, 23);
			this.applyShortcutButton.TabIndex = 5;
			this.applyShortcutButton.Text = "Apply";
			this.applyShortcutButton.UseVisualStyleBackColor = true;
			this.applyShortcutButton.Click += new System.EventHandler(this.applyShortcutButton_Click);
			// 
			// shortcut
			// 
			this.shortcut.Location = new System.Drawing.Point(18, 46);
			this.shortcut.Name = "shortcut";
			this.shortcut.Size = new System.Drawing.Size(216, 20);
			this.shortcut.TabIndex = 4;
			this.shortcut.Enter += new System.EventHandler(this.shortcut_Enter);
			this.shortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shortcut_KeyDown);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Press the key combination inside the text field ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.saveToClipboard);
			this.groupBox2.Controls.Add(this.autoSave);
			this.groupBox2.Controls.Add(this.askWhereToSave);
			this.groupBox2.Controls.Add(this.saveFolderPath);
			this.groupBox2.Controls.Add(this.chooseFolderButton);
			this.groupBox2.Location = new System.Drawing.Point(12, 126);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(250, 122);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Save options";
			// 
			// saveToClipboard
			// 
			this.saveToClipboard.AutoSize = true;
			this.saveToClipboard.Location = new System.Drawing.Point(17, 42);
			this.saveToClipboard.Name = "saveToClipboard";
			this.saveToClipboard.Size = new System.Drawing.Size(126, 17);
			this.saveToClipboard.TabIndex = 15;
			this.saveToClipboard.Text = "Save to the clipboard";
			this.saveToClipboard.UseVisualStyleBackColor = true;
			this.saveToClipboard.CheckedChanged += new System.EventHandler(this.saveToClipboard_CheckedChanged);
			// 
			// autoSave
			// 
			this.autoSave.AutoSize = true;
			this.autoSave.Location = new System.Drawing.Point(18, 65);
			this.autoSave.Name = "autoSave";
			this.autoSave.Size = new System.Drawing.Size(135, 17);
			this.autoSave.TabIndex = 14;
			this.autoSave.Text = "Save automatically to...";
			this.autoSave.UseVisualStyleBackColor = true;
			this.autoSave.CheckedChanged += new System.EventHandler(this.autoSave_CheckedChanged);
			// 
			// askWhereToSave
			// 
			this.askWhereToSave.AutoSize = true;
			this.askWhereToSave.Checked = true;
			this.askWhereToSave.Location = new System.Drawing.Point(17, 19);
			this.askWhereToSave.Name = "askWhereToSave";
			this.askWhereToSave.Size = new System.Drawing.Size(113, 17);
			this.askWhereToSave.TabIndex = 13;
			this.askWhereToSave.TabStop = true;
			this.askWhereToSave.Text = "Ask where to save";
			this.askWhereToSave.UseVisualStyleBackColor = true;
			this.askWhereToSave.CheckedChanged += new System.EventHandler(this.askWhereToSave_CheckedChanged);
			// 
			// saveFolderPath
			// 
			this.saveFolderPath.AutoSize = true;
			this.saveFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveFolderPath.Location = new System.Drawing.Point(20, 91);
			this.saveFolderPath.Name = "saveFolderPath";
			this.saveFolderPath.Size = new System.Drawing.Size(43, 13);
			this.saveFolderPath.TabIndex = 12;
			this.saveFolderPath.Text = "c:\\tmp\\";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.imageFormat);
			this.groupBox3.Location = new System.Drawing.Point(12, 254);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(250, 61);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Image";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.RestoreDirectory = true;
			// 
			// linkLabel
			// 
			this.linkLabel.AutoSize = true;
			this.linkLabel.LinkColor = System.Drawing.Color.Green;
			this.linkLabel.Location = new System.Drawing.Point(12, 387);
			this.linkLabel.Name = "linkLabel";
			this.linkLabel.Size = new System.Drawing.Size(105, 13);
			this.linkLabel.TabIndex = 15;
			this.linkLabel.TabStop = true;
			this.linkLabel.Text = "http://rafaelsteil.com";
			this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// startAutomatically
			// 
			this.startAutomatically.AutoSize = true;
			this.startAutomatically.Checked = true;
			this.startAutomatically.CheckState = System.Windows.Forms.CheckState.Checked;
			this.startAutomatically.Location = new System.Drawing.Point(14, 328);
			this.startAutomatically.Name = "startAutomatically";
			this.startAutomatically.Size = new System.Drawing.Size(117, 17);
			this.startAutomatically.TabIndex = 16;
			this.startAutomatically.Text = "Start with Windows";
			this.startAutomatically.UseVisualStyleBackColor = true;
			this.startAutomatically.CheckedChanged += new System.EventHandler(this.startAutomatically_CheckedChanged);
			// 
			// checkUpdates
			// 
			this.checkUpdates.AutoSize = true;
			this.checkUpdates.Checked = true;
			this.checkUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkUpdates.Location = new System.Drawing.Point(12, 351);
			this.checkUpdates.Name = "checkUpdates";
			this.checkUpdates.Size = new System.Drawing.Size(177, 17);
			this.checkUpdates.TabIndex = 17;
			this.checkUpdates.Text = "Automatically check for updates";
			this.checkUpdates.UseVisualStyleBackColor = true;
			this.checkUpdates.CheckedChanged += new System.EventHandler(this.checkUpdates_CheckedChanged);
			// 
			// PreferencesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.okButton;
			this.ClientSize = new System.Drawing.Size(276, 422);
			this.Controls.Add(this.checkUpdates);
			this.Controls.Add(this.startAutomatically);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.linkLabel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PreferencesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Screenshot Tool";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesForm_FormClosing);
			this.Load += new System.EventHandler(this.PreferencesForm_Load);
			this.Resize += new System.EventHandler(this.PreferencesForm_Resize);
			this.contextMenu.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notify;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem preferencesMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem screenShotMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ComboBox imageFormat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button chooseFolderButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label saveFolderPath;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton saveToClipboard;
		private System.Windows.Forms.RadioButton autoSave;
		private System.Windows.Forms.RadioButton askWhereToSave;
		private System.Windows.Forms.ToolStripMenuItem selectRegionMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.LinkLabel linkLabel;
		private System.Windows.Forms.Button applyShortcutButton;
		private System.Windows.Forms.TextBox shortcut;
		private System.Windows.Forms.CheckBox startAutomatically;
		private System.Windows.Forms.CheckBox checkUpdates;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}

