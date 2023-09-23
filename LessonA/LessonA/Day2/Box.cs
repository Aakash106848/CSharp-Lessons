using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal class Box
    {
        public static int height;
        public int width;
        public const String type = "wooden";//Value cannot be changed
        //public const String name;Value must be assigned
        public int GetHeight() { return height; }
    }
    internal class TestBox 
    {
        public static void TestOne() 
        {
            Box.height = 100;
            //Box.width = 200; is a non static varaible that can only be called by an object as reference
            //Static members of a class can be accessed without an object reference
            Box FirstBox = new Box();   
            Box SecondBox = new Box();
            FirstBox.width = 250;
            SecondBox.width = 500;
            Console.WriteLine($"FirstBox ={FirstBox.width},{FirstBox.GetHeight()}");
            Console.WriteLine($"FirstBox ={SecondBox.width},{SecondBox.GetHeight()}");
            //Box.type = "glass";
            Box.height = 5555;
            Console.WriteLine($"FirstBox ={FirstBox.width},{FirstBox.GetHeight()}");
            Console.WriteLine($"SecondBox ={SecondBox.width},{SecondBox.GetHeight()}");
            Console.WriteLine(Box.type);
        }
    }
}
