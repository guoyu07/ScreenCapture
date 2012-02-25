
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RSTL.ScreenCapture
{
	static class Program
	{
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int AllocConsole();

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern int FreeConsole();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

#if false
			AllocConsole();
#endif
			Application.Run(new PreferencesForm());

#if false
			FreeConsole();
#endif
		}
	}
}
