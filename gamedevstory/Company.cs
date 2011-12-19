using System.Collections.Generic;

namespace GameDevClone
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

		public static byte MaximumNumberOfProjects
		{
			get
			{
				if (Level <= 3)
					return (byte)(1 + Level);
				if (Level <= 5)
					return (byte) (2 + Level);
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
