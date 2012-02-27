using System;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
		public const string ShortcutKey = "Shortcut";

		public void Save()
		{
			Properties.Settings.Default.Save();
		}

		public LinkedList<Keys> Shortcut
		{
			set
			{
				KeysConverter kc = new KeysConverter();
				ArrayList l = new ArrayList();

				foreach (Keys key in value)
				{
					l.Add(kc.ConvertToString(key));
				}

				XmlSerializer x = new XmlSerializer(l.GetType());
				StringWriter writer = new StringWriter();
				x.Serialize(writer, l);
				Set(ShortcutKey, writer.ToString());
			}

			get
			{
				string s = (string)Get(ShortcutKey);

				if (String.IsNullOrEmpty(s))
				{
					return new LinkedList<Keys>();
				}

				XmlSerializer x = new XmlSerializer(typeof(ArrayList));
				ArrayList l = (ArrayList)x.Deserialize(new StringReader(s));

				KeysConverter kc = new KeysConverter();
				LinkedList<Keys> result = new LinkedList<Keys>();

				foreach (String item in l)
				{
					result.AddLast((Keys)kc.ConvertFromString(item));
				}

				return result;
			}
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
