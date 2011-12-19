using System;
using System.Linq;
using System.Windows.Forms;

namespace gamedevstory
{
	public partial class ManageEmployees : Form
	{
		public ManageEmployees()
		{
			InitializeComponent();
		}

		private void hireEmployeesButton_Click(object sender, EventArgs e)
		{
			var hire = new HireEmployees();
			hire.Show();
		}

		private void ManageEmployees_Load(object sender, EventArgs e)
		{
			employeeObjectListView.SetObjects(Company.Employees);
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
			monthlyCostsLabel.Text =  Localization.GetLocalization("ManageEmployees.MonthlyCosts") + ": " + String.Format("{0:C}", costs);
		}

		private void hireEmployeeButton_Click(object sender, EventArgs e)
		{
			var hireEmployee = new HireEmployees();
			hireEmployee.Show();
		}
	}
}
