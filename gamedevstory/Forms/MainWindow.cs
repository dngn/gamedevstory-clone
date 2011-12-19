using System;
using System.Windows.Forms;

namespace GameDevClone.Forms
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
