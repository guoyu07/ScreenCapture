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
		private bool canceled;

		public Action<Bitmap> DidTakeScreenShot { get; set; }
		public Action DidCancel { get; set; }

		public ScreenShotForm()
		{
			InitializeComponent();
		}

		private void ScreenShotForm_Paint(object sender, PaintEventArgs e)
		{
			if (!rect.IsEmpty)
			{
				using (Brush brush = new SolidBrush(Color.Lime))
				{
					e.Graphics.FillRectangle(brush, rect);
				}
			}
		}

		private void CaptureScreenshot()
		{
			Hide();

			using (Bitmap bitmap = new Bitmap(rect.Width, rect.Height))
			{
				using (Graphics g = Graphics.FromImage(bitmap))
				{
					g.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size);

					if (DidTakeScreenShot != null)
					{
						DidTakeScreenShot(bitmap);
					}
				}
			}

			Dispose();
		}

		private void ScreenShotForm_MouseDown(object sender, MouseEventArgs e)
		{
			canceled = false;
			rect = new Rectangle(e.X, e.Y, 0, 0);
			Invalidate();
		}

		private void ScreenShotForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !canceled)
			{
				rect = new Rectangle(rect.Left, rect.Top, e.X - rect.Left, e.Y - rect.Top);
				Invalidate();
			}
		}

		private void ScreenShotForm_MouseUp(object sender, MouseEventArgs e)
		{
			if (!rect.IsEmpty)
			{
				CaptureScreenshot();
			}

			rect = Rectangle.Empty;
			Invalidate();
			canceled = false;
		}

		private void ScreenShotForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!rect.IsEmpty)
			{
				canceled = true;
				rect = Rectangle.Empty;
				Invalidate();
			}
			else
			{
				if (DidCancel != null)
				{
					DidCancel();
				}

				Dispose();
			}
		}

		internal void PrintScreen()
		{
			Rectangle bounds = Screen.GetBounds(Point.Empty);
			rect = new Rectangle(0, 0, bounds.Width, bounds.Height);
			CaptureScreenshot();
		}
	}
}
