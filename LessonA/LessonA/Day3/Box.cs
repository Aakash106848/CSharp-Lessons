using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class Box
        {
            public int Height;
            public int Length;
            public int Width;
            public int area;
            public Box()
            {
                Console.WriteLine("Box Object Created");
            }
            public void Open()
            {
                Console.WriteLine("Box is Open");
            }
            public void Close()
            {
                Console.WriteLine("Box is Closed");
            }
            public override string ToString()
            {
                return ($"{Height},{Length},{Width}");
            }
        }
        internal class WoodenBox : Box 
        {
        public WoodenBox()
            {
            Console.WriteLine("Wooden box Construction");

            }
        public void Break() 
            {
            Console.WriteLine("Wooden box Has been Broken");
            }
        public override string ToString()
        {
            return ("Tom and jerry");
        }
    }
        internal class BoxTester
        {
            public static void TestOne()
            {
                Box box = new Box();
                box.Height = 10;
                box.Width = 5;
                box.Length = 20;
                box.Open();
                box.Close();
                string output =box.ToString();
                Console.WriteLine(output);

            }
        public static void TestTwo()
        {
            WoodenBox wbox = new WoodenBox();
            wbox.Height = 100;
            wbox.Width = 50;
            wbox.Length = 200;
            wbox.area = 100;
            wbox.Open();
            wbox.Close();
            
            string output = wbox.ToString();
            Console.WriteLine(output);
            wbox.Break();

        }
        public static void TestThree() 
        {
            Box box = new WoodenBox();
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            //box.Break(); no break in this class because parent doesnt inherit child class properties
            box.area = 100;
            string output = box.ToString();
            Console.WriteLine(output);
        }
    }
}
