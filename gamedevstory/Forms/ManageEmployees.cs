using System;
using System.Linq;
using System.Windows.Forms;

namespace GameDevClone.Forms
{
	public partial class ManageEmployees : Form
	{
		public ManageEmployees()
		{
			InitializeComponent();
			LocalizeForm();
		}

		private void hireEmployeesButton_Click(object sender, EventArgs e)
		{
			var hire = new HireEmployees();
			hire.Show();
		}

		private void ManageEmployees_Load(object sender, EventArgs e)
		{
			employeeObjectListView.SetObjects(Company.Employees);
			//kind of hacky
			updateTimer_Tick(null, null);
		}

		private void LocalizeForm()
		{
			Text = Localization.GetLocalization("ManageEmployees.Title");

			oNameColumn.Text = Localization.GetLocalization("Name");
			oLevelColumn.Text = Localization.GetLocalization("Level");
			oWageColumn.Text = Localization.GetLocalization("Wage");
			oProgrammingColumn.Text = Localization.GetLocalization("Skill.Programming");
			oWritingColumn.Text = Localization.GetLocalization("Skill.Writing");
			oDesigningColumn.Text = Localization.GetLocalization("Skill.Designing");
			oSoundEngineeringColumn.Text = Localization.GetLocalization("Skill.SoundEngineering");
			oArtColumn.Text = Localization.GetLocalization("Skill.Art");
			oSpecialityColumn.Text = Localization.GetLocalization("Speciality");

			hireEmployeesButton.Text = Localization.GetLocalization("HireEmployees.Title");
		}

		private void updateTimer_Tick(object sender, EventArgs e)
		{
			switch (tickVisualizer.Value)
			{
				case 0:
					tickVisualizer.Value = 100;
					break;
				case 100:
					tickVisualizer.Value = 0;
					break;
			}
			employeeObjectListView.SetObjects(Company.Employees);
			var costs = Company.Employees.Sum(employee => employee.Wage);
			monthlyExpensesLabel.Text =  Localization.GetLocalization("ManageEmployees.MonthlyExpenses") + ": " + String.Format("{0:C}", costs);
		}

		private void hireEmployeeButton_Click(object sender, EventArgs e)
		{
			var hireEmployee = new HireEmployees();
			hireEmployee.Show();
		}

		private void ManageEmployees_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}
	}
}
