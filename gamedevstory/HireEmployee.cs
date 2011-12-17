using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Skill = gamedevstory.EmployeeInfo.Skill;
namespace gamedevstory
{
	public partial class HireEmployee : Form
	{
		//private readonly Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();
		private readonly List<Employee> _employees = new List<Employee>();
		private bool _generateNewEmployees; // TODO: not used
		public HireEmployee(bool generateNewEmployees = false)
		{
			InitializeComponent();
			_generateNewEmployees = generateNewEmployees;
		}

		private void HireEmployee_Load(object sender, EventArgs e)
		{
			var rand = new Random();
			for (var i = 0; i < 10; i++)
			{
				var employee = Employee.GenerateNew(1, 10, Skill.Nothing, false, rand);
				_employees.Add(employee);
			}
			employeeObjectListView.SetObjects(_employees);
		}

		private void employeeObjectListView_DoubleClick(object sender, EventArgs e)
		{
			if (employeeObjectListView.SelectedObject != null)
			{
				var emp = (Employee) employeeObjectListView.SelectedObject;
				Console.WriteLine(emp.ToString());
			}
		}
	}
}
