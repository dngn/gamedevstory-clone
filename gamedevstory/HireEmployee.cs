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
		private readonly Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();
		private bool _generateNewEmployees; // TODO: not used s
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

				_employees.Add(employee.UniqueId, employee);
				var item = new ListViewItem
				{
					Text = employee.FirstName + ' ' + employee.LastName,
					Tag = employee.UniqueId
				};
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, employee.Level.ToString()));
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, employee.Wage + " €"));
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, employee.Skills[Skill.Programming].ToString()));
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, employee.Skills[Skill.Writing].ToString()));
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, employee.Skills[Skill.Designing].ToString()));
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, employee.Skills[Skill.SoundEngineering].ToString()));
				item.SubItems.Add(new ListViewItem.ListViewSubItem(item, employee.Skills[Skill.Art].ToString()));
				employeeListView.Items.Add(item);
				switch (employee.Speciality)
				{
					case Skill.Art:
						employeeListView.Items[employeeListView.Items.Count - 1].Group = employeeListView.Groups["artist"];
						break;
					case Skill.Writing:
						employeeListView.Items[employeeListView.Items.Count - 1].Group = employeeListView.Groups["writer"];
						break;
					case Skill.Programming:
						employeeListView.Items[employeeListView.Items.Count - 1].Group = employeeListView.Groups["programmer"];
						break;
					case Skill.Designing:
						employeeListView.Items[employeeListView.Items.Count - 1].Group = employeeListView.Groups["designer"];
						break;
					case Skill.SoundEngineering:
						employeeListView.Items[employeeListView.Items.Count - 1].Group = employeeListView.Groups["soundEngineer"];
						break;
					case Skill.Nothing:
						employeeListView.Items[employeeListView.Items.Count - 1].Group = employeeListView.Groups["nothing"];
						break;
					default:
						MessageBox.Show(employee.Speciality.ToString());
						break;
				}
			}
		}

		private void employeeListView_DoubleClick(object sender, EventArgs e)
		{
			if (employeeListView.SelectedItems.Count > 0)
			{
				MessageBox.Show("Aiot palkata seuraavan työntekijän: \n" + _employees[(int)employeeListView.SelectedItems[0].Tag]);
			}
		}
	}
}
