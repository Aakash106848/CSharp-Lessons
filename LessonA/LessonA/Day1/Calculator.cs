using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day1
{
    internal class Calculator
    {
        public static int Add(int v1 , int v2)
        {
            return v1+v2;
        }
        public static int Subtract(int v1, int v2) 
        {
            return v1-v2;
        }
        public static int Multiply(int v1, int v2)
        {
            return v1*v2;
        }
        public static int Divide(int v1 , int v2)
        {
            return v1/v2;
        }
        public static void TestCalculator() 
        {
            Console.WriteLine("give x");
            string x = Console.ReadLine();
            Console.WriteLine("give y");
            string y = Console.ReadLine();
            int a = int.Parse(x);
            int b = int.Parse(y);
            int addresult = Calculator.Add(a, b);
            Console.WriteLine(addresult);
            int subresult = Calculator.Subtract(a, b);
            Console.WriteLine(subresult);
            int mulresult = Calculator.Multiply(a, b);
            Console.WriteLine(mulresult);
            int divresult = Calculator.Divide(a, b);
            Console.WriteLine(divresult);
        }
    }
}
