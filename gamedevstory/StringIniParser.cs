using System.Collections.Generic;
using System.IO;
using System.Text;

namespace gamedevstory
{
	public class StringIniParser
	{
		private StreamReader _iniFileReader;
		public Dictionary<string, Dictionary<string, string>> SettingCollection;

		public StringIniParser(string fileName)
		{
			if (!File.Exists(fileName))
				throw new FileNotFoundException("File " + fileName + "does not exist.");
			_iniFileReader = new StreamReader(fileName, Encoding.Default);
			SettingCollection = new Dictionary<string, Dictionary<string, string>>();
			SettingCollection["default"] = new Dictionary<string, string>();
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
					if(!SettingCollection.ContainsKey(currentCategory))
					{
						SettingCollection[currentCategory] = new Dictionary<string, string>();
					}
					continue;
				}
				if(string.IsNullOrWhiteSpace(lineData))
					continue;
				var splitLine = lineData.Split('=');
				SettingCollection[currentCategory].Add(splitLine[0].Trim(), splitLine[1].Trim());
			}

		}

		public string GetSetting(string category, string settingName)
		{
			return !SettingCollection.ContainsKey(settingName) ? null : SettingCollection[category][settingName];
		}

		public void ChangeActiveIniFile(string fileName, bool initializeDictionary)
		{
			if (!File.Exists(fileName))
				throw new FileNotFoundException("File " + fileName + "does not exist.");
			_iniFileReader = new StreamReader(fileName);
				if(initializeDictionary)
			SettingCollection = new Dictionary<string, Dictionary<string, string>>();
		}

		public void SetSetting(string category, string key, string value)
		{
			SettingCollection[category][key] = value;
		}

		public void SaveIni(string fileName)
		{
			var streamWriter = new StreamWriter(fileName);
			foreach (var pair in SettingCollection)
			{
				streamWriter.WriteLine(pair.Key + "=" + pair.Value);
			}
		}
	}
}