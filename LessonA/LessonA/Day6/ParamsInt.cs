using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day6
{
    internal class ParamsInt
    {
        public static void AddIntParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        public static void TestAddIntParams()
        {
            AddIntParameters(1);
            AddIntParameters(1, 2, 3, 4, 5);
        }
    }
}
