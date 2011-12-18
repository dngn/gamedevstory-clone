using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.IO;

namespace gamedevstory
{
	public class IniParser
	{
		private StreamReader _iniFileReader;
		private Dictionary<string, Dictionary<string, object>> _settingCollection;

		public IniParser(string fileName)
		{
			if (!File.Exists(fileName))
				throw new FileNotFoundException("File " + fileName + "does not exist.");
			_iniFileReader = new StreamReader(fileName, Encoding.Default);
			_settingCollection = new Dictionary<string, Dictionary<string, object>>();
			_settingCollection["default"] = new Dictionary<string, object>();
			ReadIni();
		}

		public void ReadIni()
		{
			var currentCategory = "default";
			while (!_iniFileReader.EndOfStream)
			{
				var lineData = _iniFileReader.ReadLine().Trim();
				if(lineData.StartsWith(";"))
					continue;
				if (lineData.StartsWith("[") && lineData.EndsWith("]"))
				{
					currentCategory = lineData.Substring(1, lineData.Length - 2);
					if(!_settingCollection.ContainsKey(currentCategory))
					{
						_settingCollection[currentCategory] = new Dictionary<string, object>();
					}
					continue;
				}
				if(string.IsNullOrWhiteSpace(lineData))
					continue;
				var splitLine = lineData.Split('=');
				_settingCollection[currentCategory].Add(splitLine[0].Trim(), splitLine[1].Trim());
			}

		}

		public object GetSetting(string category, string settingName)
		{
			return !_settingCollection.ContainsKey(settingName) ? null : _settingCollection[category][settingName];
		}

		public int GetSettingAsInteger(string category, string settingName)
		{
			return Convert.ToInt32(GetSetting(category, settingName));
		}

		public float GetSettingAsFloat(string category, string settingName)
		{
			var info = new NumberFormatInfo {NumberDecimalSeparator = "."};
			return Single.Parse((string)GetSetting(category, settingName), NumberStyles.Float, info);
		}

		public string GetSettingAsString(string category, string settingName)
		{
			return Convert.ToString(GetSetting(category, settingName));
		}

		public bool GetSettingAsBoolean(string category, string settingName)
		{
			return Convert.ToBoolean(GetSetting(category, settingName));
		}

		public Color GetSettingAsColor(string category, string settingName)
		{
			var sysColor = Color.FromName(GetSettingAsString(category, settingName));
			return sysColor;
		}

		public void ChangeActiveIniFile(string fileName, bool initializeDictionary)
		{
			if (!File.Exists(fileName))
				throw new FileNotFoundException("File " + fileName + "does not exist.");
			_iniFileReader = new StreamReader(fileName);
				if(initializeDictionary)
			_settingCollection = new Dictionary<string, Dictionary<string, object>>();
		}

		public void SetSetting(string category, string key, object value)
		{
			_settingCollection[category][key] = value;
		}

		public void SaveIni(string fileName)
		{
			var streamWriter = new StreamWriter(fileName);
			foreach (var pair in _settingCollection)
			{
				streamWriter.WriteLine(pair.Key + "=" + pair.Value);
			}
		}
	}
}
