using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace gamedevstory
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Company.InitializeCompany();
			Localization.LoadLocalizationFile();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}
	}
}
