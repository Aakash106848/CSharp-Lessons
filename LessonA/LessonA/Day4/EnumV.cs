using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day4
{
    public enum City { Chennai, Banglore, Hyderabad }
    public enum Designation { Manage, Admin, Developer }
    //List of Constant
    internal class EnumV
    {

        class Employee
        {
            public enum City { Chennai, Banglore, Hyderabad, Pune }
            public enum Designation { Manager, Admin, Developer }
            public readonly int Eid;
            public string Ename = String.Empty;
            public City Ecity; //public String Ecity;
            public Designation JobTitle; //public String JobTitle
            public Employee(int v1) { Eid = v1; }
            public override String ToString()
            {
                String output = String.Empty;
                output = $"Details of the employee are: {Eid} {Ename} {Ecity} {JobTitle}";
                return output;
            }
        

        class TestEmployee
        {
            public static void TestOne()
            {
                Employee e1 = new Employee(348);
                //e1.eid = 123;
                e1.Ename = "John";
                e1.Ecity = City.Banglore; //ecity = "Chennai";
                e1.JobTitle = Designation.Developer;//edept = "Testing";
                String output = e1.ToString();
                Console.WriteLine(output);
            }
        }
    }
    }
    public enum MovieRating
    {// version number for enum constant
        VeryBad = 0,
        Bad = 1,
        Average = 2,
        Good = 3,
        Excellant = 4
    }
    public enum CarColor
    {
        Black = 0, White = 1, Red = 2, Green = 3
    }



    public enum Deserts
    {
        Icecream, Cake, MysorePak
    }
    class TestEnum
    {

        public static void TestMovieRating()
        {
            Type t1 = typeof(MovieRating);
            String[] enumNames = Enum.GetNames(t1);
            String name = String.Empty;
            int len = enumNames.Length;
            for (int i = 0; i < len; i++)
            {
                name = enumNames[i];
                MovieRating movies = (MovieRating)Enum.Parse(t1, name);
                Console.WriteLine(name + " " + (int)movies);
            }
        }

    }
}