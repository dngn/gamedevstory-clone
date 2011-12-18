using System.Collections.Generic;

namespace gamedevstory
{
	public static class Localization
	{
		private static Dictionary<string, Dictionary<string, string>> _localizations;

		public static void LoadLocalizationFile(string fileName)
		{
			var parser = new StringIniParser(fileName);
			_localizations = parser.SettingCollection;
		}

		public static string GetLocalization(string language, string stringName)
		{
			return _localizations[language][stringName];
		}
	}
}
