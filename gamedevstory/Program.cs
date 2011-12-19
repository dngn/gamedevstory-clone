using System;
using System.Windows.Forms;
using GameDevClone.Forms;

namespace GameDevClone
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			LoadConfigs();
			Company.InitializeCompany();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}

		static void LoadConfigs()
		{
			Localization.LoadLocalizationFile("localizations.ini");
			Contract.LoadContracts("contracts.ini");
		}
	}
}
