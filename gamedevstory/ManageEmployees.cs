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
			var hire = new HireEmployee();
			hire.Show();
		}
	}
}
