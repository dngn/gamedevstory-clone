using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace gamedevstory
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Company.InitializeCompany();
			Localization.LoadLocalizationFile("localizations.ini");

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
