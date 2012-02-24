using System;
using System.Diagnostics;
using System.Threading;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MovablePython;

namespace RSTL.ScreenCapture
{
	public partial class PreferencesForm : Form
	{
		private Hotkey hotKey;

		public PreferencesForm()
		{
			InitializeComponent();
			hotKey = new Hotkey();
			imageFormat.SelectedIndex = 0;
			saveFolderPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}

		~PreferencesForm()
		{
			ReleaseHotKey();
		}

		private void ReleaseHotKey()
		{
			if (hotKey != null && hotKey.Registered)
			{
				hotKey.Unregister();
			}
		}

		private void PreferencesForm_Load(object sender, EventArgs e)
		{

		}

		private void PreferencesForm_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				Hide();
			}
		}

		private void notify_DoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(this, "Do you really want to exit the application? It won't be possible to take screen shots anymore",
				"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				ReleaseHotKey();
				Application.Exit();
			}
		}

		private void PreferencesForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				Hide();
				e.Cancel = true;
			}
		}

		private void SaveScreenShot(Bitmap image)
		{
			if (saveToClipboard.Checked)
			{
				ShowBalloonMessage("Image saved to the clipboard");
				Clipboard.SetImage(image);
			}
			else if (askWhereToSave.Checked)
			{
				AskToSaveImage(image);
			}
		}

		private void AskToSaveImage(Bitmap image)
		{
			saveFileDialog.FileName = ScreenShotFileName;
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			DialogResult result = saveFileDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				image.Save(saveFileDialog.FileName, GetImageFormat);
			}
		}

		private ImageFormat GetImageFormat
		{
			get
			{
				return imageFormat.SelectedText == "JPG" ? ImageFormat.Jpeg : ImageFormat.Png;
			}
		}

		private string ScreenShotFileName
		{
			get { return string.Format("Screenshot {0}.{1}", DateTime.Now.ToString("MMM dd H-mm-s"), imageFormat.Text.ToLower()); }
		}

		private void ShowBalloonMessage(string message)
		{
			notify.BalloonTipText = message;
			notify.ShowBalloonTip(2000);
		}

		private ScreenShotForm ShowScreenShotForm()
		{
			Hide();
			Thread.Sleep(100);

			ScreenShotForm f = new ScreenShotForm();
			f.DidTakeScreenShot = (bitmap) => SaveScreenShot(bitmap);
			f.Show();

			return f;
		}

		private void screenShotMenuItem_Click(object sender, EventArgs e)
		{
			ScreenShotForm f = ShowScreenShotForm();
			f.PrintScreen();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void selectRegionMenuItem_Click(object sender, EventArgs e)
		{
			ShowScreenShotForm();
		}

		private void preferencesMenuItem_Click(object sender, EventArgs e)
		{
			Show();
		}

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Cursor original = Cursor.Current;

			try
			{
				Cursor.Current = Cursors.WaitCursor;
				Process.Start("http://rafaelsteil.com");
			}
			catch (Exception)
			{
			}
			finally
			{
				Cursor.Current = original;
			}
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm f = new AboutForm();
			f.ShowDialog(this);
		}
	}
}
