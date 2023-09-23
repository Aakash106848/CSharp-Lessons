using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day5
{
    internal class Empl
    {
        class Emp
        {
            private readonly double Id;
            public string Name = string.Empty;
            public string FirstName { get; set; } = string.Empty;
            public string MiddleName { get; set; } = string.Empty;

            public string LastName { get; set; } = string.Empty;
            public double Salary { get; set; }
            public Emp() { }
            public Emp(double v1)
            {
                Id = v1;
            }
            public double GetID()
            {
                return Id;
            }
        }
        public static void EmpArray()
        {
            Emp[] elist = new Emp[10];
            for (int i = 0; i < 10; i++)
            {
                Emp e1 = new Emp(i);

                e1.FirstName = "Emp" + i;
                elist[i] = e1;
            }



            Console.WriteLine("No of Employees " + elist.Length);
            for (int i = 0; i < 10; i++)
            {
                Emp e1 = elist[i];
                Console.WriteLine("ID=" + e1.GetID() + " Name=" + e1.FirstName);
            }
        }

    }
}
