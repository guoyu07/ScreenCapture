using System;
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
			//Hide();
			//e.Cancel = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ScreenShotForm f = new ScreenShotForm();
			f.Show();
		}
	}
}
