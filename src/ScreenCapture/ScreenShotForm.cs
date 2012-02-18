using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSTL.ScreenCapture
{
	public partial class ScreenShotForm : Form
	{
		private Rectangle rect;

		public ScreenShotForm()
		{
			InitializeComponent();
		}

		private void ScreenShotForm_Paint(object sender, PaintEventArgs e)
		{
			if (!rect.Equals(Rectangle.Empty))
			{
				using (Brush brush = new SolidBrush(Color.FromArgb(128, 166, 166, 166)))
				{
					e.Graphics.FillRectangle(brush, rect);
				}
			}
		}

		private void ScreenShotForm_MouseDown(object sender, MouseEventArgs e)
		{
			rect = new Rectangle(e.X, e.Y, 0, 0);
			Invalidate();
		}

		private void ScreenShotForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				rect = new Rectangle(rect.Left, rect.Top, e.X - rect.Left, e.Y - rect.Top);
				Invalidate();
			}
		}

		private void ScreenShotForm_MouseUp(object sender, MouseEventArgs e)
		{
			rect = Rectangle.Empty;
			Invalidate();
		}
	}
}
