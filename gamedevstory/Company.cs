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
		public static byte Level = 1; // 1 to 10

		public static void InitializeCompany()
		{
			Employees = new List<Employee>();
		}

		public static byte MinimunNormalEmployeeLevel
		{
			get
			{
				if (Level > 3)
				{
					return (byte)(Level - 2);
				}
				return Level;
			}
		}

		public static byte MaximumNormalEmployeeLevel
		{
			get
			{
				if (Level > 8)
				{
					return 10;
				}
				return (byte)(Level + 2);
			}
		}
	}
}
