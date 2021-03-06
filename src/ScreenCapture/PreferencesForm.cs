﻿using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
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
		[DllImport("user32.dll")]
		private static extern bool HideCaret(IntPtr hWnd);
		private Hotkey hotKey;
		private LinkedList<Keys> shortcutKeys = new LinkedList<Keys>();

		public PreferencesForm()
		{
			InitializeComponent();
		}

		private void RestoreSettings()
		{
			UserSettings s = new UserSettings();
			
			imageFormat.SelectedItem = s.ImageFormat;
			saveFolderPath.Text = s.SaveDirectory == String.Empty ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : s.SaveDirectory;
			startAutomatically.Checked = s.StartWithWindows;
			checkUpdates.Checked = s.AutoCheckUpdates;
			shortcutKeys = s.Shortcut;

			if (s.SaveBehavior == SaveBehaviorEnum.Ask)
			{
				askWhereToSave.Checked = true;
			}
			else if (s.SaveBehavior == SaveBehaviorEnum.Clipboard)
			{
				saveToClipboard.Checked = true;
			}
			else if (s.SaveBehavior == SaveBehaviorEnum.Directory)
			{
				autoSave.Checked = true;
			}

			DisplayShortcut();
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
				//Hide();
				//e.Cancel = true;
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
			else if (autoSave.Checked)
			{
				if (!Directory.Exists(saveFolderPath.Text))
				{
					AskToSaveImage(image);
				}
				else
				{
					image.Save(saveFolderPath.Text, GetImageFormat);
				}
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
			get { return string.Format("Screenshot {0}.{1}", DateTime.Now.ToString("MMM-dd H.mm.s"), imageFormat.Text.ToLower()); }
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
			new UserSettings().Save();
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

		private void shortcut_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
			e.Handled = true;

			if (ShortcutContainsKey(e))
			{
				return;
			}

			if (e.KeyCode == Keys.Back)
			{
				if (shortcutKeys.Count > 0)
				{
					shortcutKeys.RemoveLast();
				}
			}
			else if (CountNonMetaKeys() == 0)
			{
				shortcutKeys.AddLast(e.KeyCode);
			}

			DisplayShortcut();
		}

		private void DisplayShortcut()
		{
			StringBuilder sb = new StringBuilder();

			foreach (Keys k in SortShortcuts())
			{
				if (sb.Length > 0)
				{
					sb.Append(" + ");
				}

				sb.AppendFormat("{0}", GetNiceKey(k));
			}

			shortcut.Text = sb.ToString();
		}

		private IEnumerable<Keys> SortShortcuts()
		{
			return (from item in shortcutKeys orderby item select item);
		}

		private int CountNonMetaKeys()
		{
			return (from item in shortcutKeys where !IsMetaKey(item) select item).Count();
		}

		private bool ShortcutContainsKey(KeyEventArgs e)
		{
			return (from item in shortcutKeys where item == e.KeyCode select item).Count() > 0;
		}

		private bool IsMetaKey(Keys k)
		{
			return k == Keys.ShiftKey || k == Keys.ControlKey
				|| k == Keys.Menu || k == Keys.RWin || k == Keys.LWin;
		}

		private string GetNiceKey(Keys key)
		{
			if (key == Keys.ControlKey)
			{
				return "CTRL";
			}
			else if (key == Keys.Menu || key == Keys.Alt)
			{
				return "ALT";
			}
			else if (key == Keys.LWin || key == Keys.RWin)
			{
				return "WIN";
			}
			else if (key == Keys.ShiftKey)
			{
				return "SHIFT";
			}
			else if (key >= Keys.D0 && key <= Keys.D9)
			{
				return ((char)key).ToString();
			}

			return key.ToString();
		}

		private void shortcut_Enter(object sender, EventArgs e)
		{
			HideCaret(shortcut.Handle);
		}

		private void applyShortcutButton_Click(object sender, EventArgs e)
		{
			try
			{
				int notMetaCount = shortcutKeys.Count(k => !IsMetaKey(k));
				if (notMetaCount == 0)
				{
					ShowErrorMessage("You should also choose one character that is not CTRL, SHIFT, ALT or WIN");
					return;
				}

				bool ctrl = false;
				bool shift = false;
				bool alt = false;
				bool win = false;
				Keys key = Keys.F19;

				foreach (Keys item in shortcutKeys)
				{
					if (item == Keys.ControlKey)
					{
						ctrl = true;
					}
					else if (item == Keys.ShiftKey)
					{
						shift = true;
					}
					else if (item == Keys.LWin || item == Keys.RWin)
					{
						win = true;
					}
					else if (item == Keys.Alt || item == Keys.Menu)
					{
						alt = true;
					}
					else
					{
						key = item;
					}
				}

				if (hotKey != null && hotKey.Registered)
				{
					hotKey.Unregister();
				}

				hotKey = new Hotkey(key, shift, ctrl, alt, win);
				hotKey.Pressed += (hkSender, hkArgs) => ShowScreenShotForm();

				if (hotKey.GetCanRegister(shortcut))
				{
					hotKey.Register(shortcut);
					new UserSettings().Shortcut = shortcutKeys;
				}
				else
				{
					MessageBox.Show(this, "There is another application using this combination already. Please choose another one", 
						"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				ShowErrorMessage(ex.Message);
			}
		}

		private void ShowErrorMessage(string message)
		{
			MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void askWhereToSave_CheckedChanged(object sender, EventArgs e)
		{
			new UserSettings().SaveBehavior = SaveBehaviorEnum.Ask;
		}

		private void saveToClipboard_CheckedChanged(object sender, EventArgs e)
		{
			new UserSettings().SaveBehavior = SaveBehaviorEnum.Clipboard;
		}

		private void autoSave_CheckedChanged(object sender, EventArgs e)
		{
			new UserSettings().SaveBehavior = SaveBehaviorEnum.Directory;
		}

		private void chooseFolderButton_Click(object sender, EventArgs e)
		{
			DialogResult result = folderBrowserDialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				saveFolderPath.Text = folderBrowserDialog.SelectedPath;
				new UserSettings().SaveDirectory = folderBrowserDialog.SelectedPath;
			}
		}

		private void imageFormat_SelectedIndexChanged(object sender, EventArgs e)
		{
			new UserSettings().ImageFormat = imageFormat.Text;
		}

		private void PreferencesForm_Load(object sender, EventArgs e)
		{
			RestoreSettings();
		}

		private void startAutomatically_CheckedChanged(object sender, EventArgs e)
		{
			new UserSettings().StartWithWindows = startAutomatically.Checked;
		}

		private void checkUpdates_CheckedChanged(object sender, EventArgs e)
		{
			new UserSettings().AutoCheckUpdates = checkUpdates.Checked;
		}
	}
}
