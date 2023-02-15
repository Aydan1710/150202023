using System;

namespace _14022023
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();

            while(true)
            {
                Console.WriteLine("FullName:");
                string fullname = Console.ReadLine();

                if(Student.CheckFullName(fullname))
                {
                    std.FullName = fullname;
                    break;
                }
                Console.WriteLine("Yeniden cehd edin");

            }

            while(true)
            {
                Console.WriteLine("GroupNo:");
                string groupNo = Console.ReadLine();

                if (Student.CheckGroupNo(groupNo))
                {
                    std.GroupNo = groupNo;
                    break;
                }
                Console.WriteLine("Yeniden cehd edin");


            }

            while(true)
            {
                Console.WriteLine("Age");
                int age;
                if (int.TryParse(Console.ReadLine(),out age))
                {
                    std.Age = age;
                    break;
                }
                Console.WriteLine("Yeniden cehd edin");


                
            }



            Console.WriteLine($"Student:{std.FullName},GroupNo:{std.GroupNo},Age:{std.Age}");
            
        }
    }
}

