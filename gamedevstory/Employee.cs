using System;
using System.Collections.Generic;
using System.Text;
using Skill = gamedevstory.EmployeeInfo.Skill;

namespace gamedevstory
{
	public class Employee
	{

		public const int MinimumWage = 100;

		public string FirstName;
		public string LastName;
		public byte Level{ get; set;} // from 1 to 10
		public int Wage{ get; set;}
		public int Experience;
		public byte Stress; // from 0 to 10
		public Skill Speciality;
		public int UniqueId;

		public Dictionary<Skill, byte> Skills; // skill levels go from 1 to 100

		public Employee(string firstName, string lastName, byte level, int wage, Dictionary<Skill, byte> skills, Skill speciality)
		{
			FirstName = firstName;
			LastName = lastName;
			Level = level;
			Wage = wage;
			Skills = skills;
			Speciality = speciality;
			UniqueId = firstName.GetHashCode() + lastName.GetHashCode() + level.GetHashCode() + wage.GetHashCode();
		}

		public string FullName
		{
			get{return FirstName + " " + LastName;}
		}
		
		public byte ProgrammingSkill
		{
			get{ return Skills[Skill.Programming]; }
			set{ Skills[Skill.Programming] = value; }
		}

		public byte WritingSkill
		{
			get{ return Skills[Skill.Writing]; }
			set{ Skills[Skill.Writing] = value; }
		}

		public byte ArtSkill
		{
			get{ return Skills[Skill.Art]; }
			set{ Skills[Skill.Art] = value; }
		}

		public byte SoundEngineeringSkill
		{
			get { return Skills[Skill.SoundEngineering]; }
			set { Skills[Skill.SoundEngineering] = value; }
		}

		public byte DesigningSkill
		{
			get { return Skills[Skill.Designing]; }
			set { Skills[Skill.Designing] = value; }
		}

		public override string ToString()
		{
			var builder = new StringBuilder();
			builder.AppendLine("Nimi: " + FirstName + " " + LastName);
			builder.AppendLine("Taitotaso: " + Level);
			builder.AppendLine("Palkka: " + Wage + "€");
			builder.AppendLine("Speciality: " + Speciality);
			builder.AppendLine("UniqueId: " + UniqueId);
			return builder.ToString();
		}

		public static Employee GenerateNew(byte minLevel, byte maxLevel, Skill speciality = Skill.Nothing, bool noSkills = false, Random random = null)
		{
			var rand = random ?? new Random();
			var firstName = Utils.GetRandomString(EmployeeInfo.FirstNames, rand);
			var lastName = Utils.GetRandomString(EmployeeInfo.LastNames, rand);
			var level = (byte) rand.Next(minLevel, maxLevel);
			var wage = rand.Next((int)(MinimumWage * level * 0.75f), (int)(MinimumWage * level * 1.5f));
			var skills = new Dictionary<Skill, byte>();
			var spec = speciality;
			if (speciality == Skill.Nothing && noSkills == false)
			{
				spec = Utils.GetRandomEnum<Skill>(rand);
			}
			foreach (Skill skill in Enum.GetValues(typeof(Skill)))
			{
				byte skillLevel;
				if(skill == spec)
				{
					skillLevel = (byte)rand.Next(level * 5, level * 10 + 1);
					if (skillLevel > 90)
						wage=(int)(wage * 1.25f);
				}
				else
				{
					skillLevel = (byte)rand.Next(level, level * 5 + 1);
				}
				skills.Add(skill, skillLevel);
			}
			return new Employee(firstName, lastName, level, wage, skills, spec);
		}
	}

}
