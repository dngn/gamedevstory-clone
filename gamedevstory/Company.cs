using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gamedevstory
{
	public static class Company
	{
		public static List<Employee> Employees;
		public static int Money;
		public static byte Level;

		public static void InitializeCompany()
		{
			Employees = new List<Employee>();

		}
	}
}
