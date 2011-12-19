using System;
using System.Collections.Generic;

namespace GameDevClone
{
	public static class Localization
	{
		private static Dictionary<string, Dictionary<string, string>> _localizations;
		public static string CurrentLanguage = "English";

		public static void LoadLocalizationFile(string fileName)
		{
			var parser = new StringIniParser(fileName);
			_localizations = parser.SettingCollection;
		}

		public static string GetLocalization(string stringName)
		{
			if (!_localizations[CurrentLanguage].ContainsKey(stringName))
			{
				Console.WriteLine("Missing localization: " + stringName);
				return stringName;
			}
			return _localizations[CurrentLanguage][stringName];
		}
	}
}
