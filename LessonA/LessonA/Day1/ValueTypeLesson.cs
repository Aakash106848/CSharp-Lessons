using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day1
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()    
        {
            byte b1 = 255;
            Console.WriteLine(b1);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            float f1 = 52.678f;
            long l1 = 9999999999L;
            Console.WriteLine(l1);
            Console.WriteLine(f1);
            double d1 = 3.33d;
            Console.WriteLine(d1);
            decimal d2 = 10 / 3m;
            Console.WriteLine(d2);
            char c1 = 'a';
            Console.WriteLine(c1);
            int x = c1;
            Console.WriteLine(x);
            int y = 45;
            char c2 = (char)y;
            Console.WriteLine(c2);
            TestMethod();
         
        }
        public static void TestMethod()
        {
            Console.WriteLine("test");
        }
    }
}
