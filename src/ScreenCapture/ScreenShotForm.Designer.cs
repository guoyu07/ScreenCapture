namespace RSTL.ScreenCapture
{
	partial class ScreenShotForm
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
			this.SuspendLayout();
			// 
			// ScreenShotForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(545, 348);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ScreenShotForm";
			this.Opacity = 0.6D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TransparencyKey = System.Drawing.Color.Lime;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenShotForm_Paint);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ScreenShotForm_KeyPress);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenShotForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenShotForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenShotForm_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion
	}
}