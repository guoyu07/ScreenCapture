using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace RSTL.ScreenCapture
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
			LoadLicense();
		}

		private void LoadLicense()
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			Stream stream = assembly.GetManifestResourceStream("RSTL.ScreenCapture.License.txt");

			using (StreamReader reader = new StreamReader(stream))
			{
				licenseTextBox.Text = reader.ReadToEnd();
			}
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void websiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			OpenLink((Label)sender);
		}

		private void OpenLink(Label link)
		{
			try
			{
				Process.Start(link.Text);
			}
			catch (Exception)
			{
			}
		}
	}
}
