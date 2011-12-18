using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;
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
			GenerateNewEmployees(20);
			employeeObjectListView.SetObjects(_employees);
			oSpecialityColumn.ImageGetter = new ImageGetterDelegate(Employee.EmployeeSpecialityImageGetter);
		}

		private void employeeObjectListView_DoubleClick(object sender, EventArgs e)
		{
			if (employeeObjectListView.SelectedObject == null) return;

			var emp = (Employee) employeeObjectListView.SelectedObject;
			Console.WriteLine(emp.ToString());
			Company.Employees.Add(emp);
			_employees.Remove(emp);
		}

		public void GenerateNewEmployees(int count)
		{
			var generatedNames = new List<string>();
			var rand = new Random();

			for (var i = 0; i < count - (int)(count * 0.25f); i++)
			{
				Employee employee;

				do
				{
					employee = Employee.GenerateNew(Company.MinimunNormalEmployeeLevel, Company.MaximumNormalEmployeeLevel, Skill.Nothing, false, rand);
				} while (generatedNames.Contains(employee.FullName));

				generatedNames.Add(employee.FullName);
				_employees.Add(employee);
			}
			for (var i = 0; i < (int)(count * 0.25f); i++)
			{
				Employee employee;

				do
				{
					employee = Employee.GenerateNew(1, 10, Skill.Nothing, false, rand);
				} while (generatedNames.Contains(employee.FullName));

				generatedNames.Add(employee.FullName);
				_employees.Add(employee);
			}
		}
	}
}
