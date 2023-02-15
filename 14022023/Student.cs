using System;
namespace _14022023
{
	public class Student
	{
	

		public string FullName { get; set; }
		public double Age { get; set; }
		public byte GroupNo { get; set; }


		public static bool CheckFullName(string fullname)
		{
			string[] names = fullname.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			if(names.Length!=2)
			{
				return false;
			}

			if (string.IsNullOrEmpty(names[0]) ||! string.IsNullOrEmpty(names[1]))
			{
				return false;
			}
			return true;
		}


		public static bool CheckGroupNo(int groupNo)
		{
			if(groupNo>=0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}



	}

}

