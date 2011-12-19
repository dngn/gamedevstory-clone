using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Skill = gamedevstory.EmployeeInfo.Skill;
namespace gamedevstory
{
	public partial class HireEmployees : Form
	{
		//private readonly Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();
		private readonly List<Employee> _employees = new List<Employee>();
		public HireEmployees()
		{
			InitializeComponent();
			LocalizeForm();
		}

		private void HireEmployee_Load(object sender, EventArgs e)
		{
			GenerateNewEmployees(20);
			employeeObjectListView.SetObjects(_employees);
			oSpecialityColumn.ImageGetter = new ImageGetterDelegate(Employee.EmployeeSpecialityImageGetter);
		}

		private void EmployeeObjectListViewDoubleClick(object sender, EventArgs e)
		{
			if (employeeObjectListView.SelectedObject == null) return;

			var emp = (Employee)employeeObjectListView.SelectedObject;
			Console.WriteLine(emp.ToString());
			Company.Employees.Add(emp);
			_employees.Remove(emp);
			employeeObjectListView.RemoveObject(emp);
		}

		private void LocalizeForm()
		{
			Text = Localization.GetLocalization("HireEmployees.Title");
			oNameColumn.Text = Localization.GetLocalization("Name");
			oLevelColumn.Text = Localization.GetLocalization("Level");
			oWageColumn.Text = Localization.GetLocalization("Wage");
			oProgrammingColumn.Text = Localization.GetLocalization("Skill.Programming");
			oWritingColumn.Text = Localization.GetLocalization("Skill.Writing");
			oDesigningColumn.Text = Localization.GetLocalization("Skill.Designing");
			oSoundEngineeringColumn.Text = Localization.GetLocalization("Skill.SoundEngineering");
			oArtColumn.Text = Localization.GetLocalization("Skill.Art");
			oSpecialityColumn.Text = Localization.GetLocalization("Speciality");
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

				if (employee.FullName == "Markus Persson")
					employee.ProgrammingSkill = 0;

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

				if (employee.FullName == "Markus Persson")
					employee.ProgrammingSkill = 0;

				generatedNames.Add(employee.FullName);
				_employees.Add(employee);
			}
		}
	}
}
