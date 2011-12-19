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
	public partial class MainWindow : Form
	{
		private ManageEmployees _manageEmployeesForm = new ManageEmployees();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void työntekijätToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_manageEmployeesForm.Show();
			_manageEmployeesForm.Focus();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			var rand = new Random();
			/*for (var i = 0; i < 10; i++)
			{
				var emp = Employee.GenerateNew(1, 10, EmployeeInfo.Skill.Nothing, false, rand);
				Console.WriteLine("Name: " + emp.FirstName + " " + emp.LastName);
				Console.WriteLine("Speciality: " + emp.Speciality.ToString());
			}*/
		}
	}
}
