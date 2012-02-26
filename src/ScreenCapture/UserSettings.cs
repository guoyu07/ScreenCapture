using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSTL.ScreenCapture
{
	public class UserSettings
	{
		public const string ImageFormatKey = "ImageFormat";
		public const string SaveDirectoryKey = "SaveDirectory";
		public const string StartWithWindowsKey = "StartWithWindows";
		public const string AutoCheckUpdatesKey = "AutoCheckUpdates";
		public const string HotKeyShortcutKey = "HotKeyShortcut";
		public const string SaveBehaviorKey = "SaveBehavior";

		public void Save()
		{
			Properties.Settings.Default.Save();
		}

		public string ImageFormat
		{
			get { return (string)Get(ImageFormatKey); }
			set { Set(ImageFormatKey, value); }
		}

		public string SaveDirectory
		{
			get { return (string)Get(SaveDirectoryKey); }
			set { Set(SaveDirectoryKey, value); }
		}

		public bool StartWithWindows
		{
			get { return (bool)Get(StartWithWindowsKey); }
			set { Set(StartWithWindowsKey, value); }
		}

		public bool AutoCheckUpdates
		{
			get { return (bool)Get(AutoCheckUpdatesKey); }
			set { Set(AutoCheckUpdatesKey, value); }
		}

		public SaveBehaviorEnum SaveBehavior
		{
			get { return (SaveBehaviorEnum)Enum.Parse(typeof(SaveBehaviorEnum), (string)Get(SaveBehaviorKey), false); }
			set { Set(SaveBehaviorKey, Enum.GetName(typeof(SaveBehaviorEnum), value)); }
		}

		private object Get(string key)
		{
			return Properties.Settings.Default[key];
		}

		private void Set(string key, object value)
		{
			Properties.Settings.Default[key] = value;
		}
	}
}
