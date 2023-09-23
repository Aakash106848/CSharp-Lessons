using LessonA.Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day6
{
    //Hash code is a number provided by the runtime
    internal class WorkingWithObjects
    {
        class Emp
        {
            public int ID;
            public string Name = string.Empty;
            public double Salary;


        }
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001;
            Emp empTwo = new Emp();
            empTwo.ID = 1002;
            Emp empThree = new Emp();
            empThree.ID = 103;
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());



        }
        class Box
        {
            List<int> noList = new List<int>();
            public void FillList(int from, int to)
            {
                int i = 0;
                for (i = from; i < to; i++)
                {
                    noList.Add(i);
                }
            }
            public List<int> GetList()
            {
                return noList;
            }
        }
        class BoxA<T>
        {
            List<T> myList = new List<T>();
            public void FillList(T data)
            {
                myList.Add(data);
            }
            public List<T> GetList()
            {
                return myList;
            }
        }
            public static void TestA()
            {
                Box b1 = new Box();
                b1.FillList(100, 110);
                List<int> l = b1.GetList();
                foreach (int x in l)
                {
                    Console.WriteLine(x);
                }
            }
            public static void TestB()
            {
                BoxA<string> b1 = new BoxA<string>();
                b1.FillList("Hello");
                List<string> l = b1.GetList();
                foreach (string s in l)
                    Console.WriteLine(s);



                BoxA<float> b2 = new BoxA<float>();
                b2.FillList(55.24f);
                List<float> flist = b2.GetList();
                foreach (float f in flist)
                    Console.WriteLine(f);
            }
        }
    }

