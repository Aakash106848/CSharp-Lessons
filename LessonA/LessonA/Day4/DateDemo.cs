using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day4
{
    internal class DateDemo
    {
        public static void FirstMethod()
        {
            Console.WriteLine(DateTime.Now);
            DateTime t1 = new DateTime(2401, 01, 24);
            Console.WriteLine(t1.ToLongDateString());
            Console.WriteLine(t1.ToShortDateString());
        }
        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }
        public static void FindAge()
        {
            try
            {
                Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
                String strdob = Console.ReadLine();
                DateTime d1 = DateTime.Parse(strdob);
                DateTime d2 = DateTime.Now;
                TimeSpan c = d2.Subtract(d1);
                DateTime age = new DateTime(c.Ticks);
                Console.WriteLine(age.ToShortDateString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AgeOfPerson() 
        {
            // Prompt the user for their date of birth
            Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            string dobString = String.Empty;
            try
            {
                dobString = Console.ReadLine();
                if (dobString == null)
                {
                    Console.WriteLine("Date Of Birth is NULL!!!");
                    return;
                }
                // Parse the date of birth
                DateTime dob = DateTime.Parse(dobString);



                // Calculate the age
                DateTime now = DateTime.Now;
                int ageYears = now.Year - dob.Year;
                if (now < dob.AddYears(ageYears))
                {
                    ageYears--;
                }
                int ageMonths = now.Month - dob.Month;
                if (now < dob.AddMonths(ageMonths).AddDays(now.Day - dob.Day))
                {
                    ageMonths--;
                }
                int ageDays = now.Day - dob.Day;
                if (now.Day < dob.Day)
                {
                    ageDays += DateTime.DaysInMonth(now.Year, now.Month);
                }
                // Print the age
                Console.WriteLine(
                    $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void RetirementAge() 
        {
            try
            {
                Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
                String strdob = Console.ReadLine();
                DateTime d1 = DateTime.Parse(strdob);
                DateTime d4 = new DateTime(d1.Year + 60, d1.Month + 1, 1);
                DateTime d5 = d4.AddDays(-1);


                Console.WriteLine("HappyRetirementDayOn:" + d5.ToShortDateString());
            } catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        class Employee
        { 

        }

    }
}
