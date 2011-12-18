using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			Console.WriteLine("lol");
			employeeObjectListView.SetObjects(Company.Employees);
			var costs = Company.Employees.Sum(employee => employee.Wage);
			monthlyCostsLabel.Text = "Kuukausittaiset menot: " + String.Format("{0:C}", costs);
		}

		private void hireEmployeeButton_Click(object sender, EventArgs e)
		{
			var hireEmployee = new HireEmployees();
			hireEmployee.Show();
		}
	}
}
