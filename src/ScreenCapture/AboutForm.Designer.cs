namespace RSTL.ScreenCapture
{
	partial class AboutForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.licenseTextBox = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.websiteLink = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(424, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Screenshoot Tool 1.0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(18, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(418, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "screenshots made easy!";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// licenseTextBox
			// 
			this.licenseTextBox.Location = new System.Drawing.Point(18, 101);
			this.licenseTextBox.Name = "licenseTextBox";
			this.licenseTextBox.Size = new System.Drawing.Size(418, 131);
			this.licenseTextBox.TabIndex = 2;
			this.licenseTextBox.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "License";
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(195, 238);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 7;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// websiteLink
			// 
			this.websiteLink.AutoSize = true;
			this.websiteLink.Location = new System.Drawing.Point(18, 244);
			this.websiteLink.Name = "websiteLink";
			this.websiteLink.Size = new System.Drawing.Size(105, 13);
			this.websiteLink.TabIndex = 8;
			this.websiteLink.TabStop = true;
			this.websiteLink.Text = "http://rafaelsteil.com";
			this.websiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLink_LinkClicked);
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 273);
			this.Controls.Add(this.websiteLink);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.licenseTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox licenseTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.LinkLabel websiteLink;
	}
}