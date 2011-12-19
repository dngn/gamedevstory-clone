using System.Collections.Generic;

namespace GameDevClone
{
	public class Project
	{
		public byte Completion;
		public List<Employee> EmployeesAssigned;
	}

	public static class ProjectInfo
	{
		public enum ProjectStat
		{
			Originality,  // by everyone
			Fun, // by designer
			Graphics, // by artist
			Sound, // by sound engineer
			Story, // by writer
			Bugs, // created & reduced by programmers
			Hype
		}
	}
}
