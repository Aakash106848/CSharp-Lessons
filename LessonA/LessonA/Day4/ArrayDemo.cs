using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonA.Day5;
//debuff : finite ,not sortable
// no behaviour on its own , homogenous nature,only carries one data type
//buff : take less memory,efficient]
//100< go for an array not collection
//not sure about the no. of contents ,go for a collection
// multi dimentional ; 1 ,2 ,3 dimensions
// rdbms = 2 dimensional(x,y)
//array inside an array ,jagged array
//un even arrays are possible

internal class ArrayDemo
{
    public static void FirstMethod()
    {
        int[] sample = new int[10];
        //int a[] = new int[10];(illegal)
        int length = sample.Length;
        int i;
        Random random = new Random();
        for (i = 0; i < length; i = i + 1)
            sample[i] = random.Next(100);
        for (i = 0; i < length; i++)
            Console.WriteLine("sample[" + i + "]: " + sample[i]);
        Console.WriteLine(sample.Average());
        Console.WriteLine(sample.Sum());
        Console.WriteLine(sample.Max());
        Console.WriteLine(sample.Min());
    }
    public static void ArrayOverRun()
    {
        int[] sample = new int[10];
        int i;
        // Generate an array overrun.
        for (i = 0; i < 100; i = i + 1)
            sample[i] = i;
        //IndexOutOfRangeException
    }
    public static void TwoD()
    {
        int t, i;
        int[,] table = new int[3, 4];//3 Rows - 4 Col
        for (t = 0; t < 3; ++t)
        {
            for (i = 0; i < 4; ++i)
            {
                table[t, i] = t * 4 + i + 1;
                Console.Write(table[t, i] + " ");
            }
            Console.WriteLine();
        }
    }
    public static void ThreeD()
    {
        int[,,] m = new int[3, 3, 3];
        //int sum = 0;
        int n = 1;
        
        //m[0, 0, 0] = 1; m[0, 0, 1] = 2; m[0, 0, 2] = 3;
        //m[0, 1, 0] = 4; m[0, 1, 1] = 5; m[0, 1, 2] = 6;
        //m[0, 2, 0] = 7; m[0, 2, 1] = 8; m[0, 2, 2] = 9;



        //m[1, 0, 0] = 10; m[1, 0, 1] = 11; m[1, 0, 2] = 12;
        //m[1, 1, 0] = 13; m[1, 1, 1] = 14; m[1, 1, 2] = 15;
        //m[1, 2, 0] = 16; m[1, 2, 1] = 17; m[1, 2, 2] = 18;



        //m[2, 0, 0] = 19; m[2, 0, 1] = 20; m[2, 0, 2] = 21;
        //m[2, 1, 0] = 22; m[2, 1, 1] = 23; m[2, 1, 2] = 24;
        //m[2, 2, 0] = 25; m[2, 2, 1] = 26; m[2, 2, 2] = 27;

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    m[x, y, z] = n++;
                }
            }
        }
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    Console.Write(m[x, y, z] + " ,");
                }
                Console.WriteLine();
            }
        }
    }
    public static void UsingJaggedArrays()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        int i;
        // Store values in first array.
        for (i = 0; i < 4; i++)
            jagged[0][i] = i;
        // Store values in second array.
        for (i = 0; i < 3; i++)
            jagged[1][i] = i;
        // Store values in third array.
        for (i = 0; i < 5; i++)
            jagged[2][i] = i;
        // Display values in first array.
        for (i = 0; i < 4; i++)
            Console.Write(jagged[0][i] + " ");
        Console.WriteLine();
        // Display values in second array.
        for (i = 0; i < 3; i++)
            Console.Write(jagged[1][i] + " ");
        Console.WriteLine();
        // Display values in third array.
        for (i = 0; i < 5; i++)
            Console.Write(jagged[2][i] + " ");
        Console.WriteLine();
    }
    public static void SortingArrays()
    {
        int[] nos = { 32, 21, 10, 56, 87, 43, 97, 2 };
        Console.WriteLine("B4 sort ");
        int len = nos.Length;
        for (int i = 0; i < len; i++)
        {
            Console.Write(nos[i] + ",");
        }
        Console.WriteLine();
        Array.Sort(nos);
        Console.WriteLine("After sort ");



        len = nos.Length;
        for (int i = 0; i < len; i++)
        {
            Console.Write(nos[i] + ",");
        }
        Console.WriteLine();
    }
    public static void TestArrayList()
    {
        ArrayList alist = new ArrayList();
        int count = alist.Count;
        Console.Write("Count " + count);
        Console.WriteLine(" Capacity " + alist.Capacity);// 0
        Random r1 = new Random();
        for (int i = 0; i < 10; i++)
            alist.Add(r1.Next(10));
        Console.Write("Count " + alist.Count);
        Console.WriteLine(" Capacity " + alist.Capacity);// 16
        for (int j = 0; j < 10; j++) alist.Add(j);
        Console.Write("Count " + alist.Count);
        Console.WriteLine(" Capacity " + alist.Capacity);// 32 
        for (int i = 0; i < alist.Count; i++)
        {
            Console.Write(alist[i] + ",");
            if (i > 0 && i % 10 == 0) Console.WriteLine();
        }
        Console.WriteLine("");
        foreach (int x in alist)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine("");
        if (alist is IEnumerable)//does alist impliment IEnumerable
        {
            IEnumerator er = alist.GetEnumerator();
            while (er.MoveNext())
            {
                object obj = er.Current;
                if (typeof(int) == obj.GetType())
                {
                    int x = (int)obj;// unboxing
                    Console.WriteLine(x);
                }
                else
                    Console.WriteLine(obj.ToString());
            }
        }
    }
    public static void GenericListInteger()
    {
        List<int> alist = new List<int>();
        int count = alist.Count;
        Console.Write("Count " + count);
        Console.WriteLine(" Capacity " + alist.Capacity);



        for (int i = 0; i < 10; i++)
            alist.Add(i);
        Console.Write("Count " + alist.Count);
        Console.WriteLine(" Capacity " + alist.Capacity);



        //for (int j = 0; j < 10; j++)
        //    alist.Add("abcd" + j);





        for (int i = 0; i < count; i++)
        {
            Console.Write(alist[i] + ",");
        }
    }
    public static void Anagram()
    {
        string str = "He was at the 24 floor of the building. He saw 42 pots of flowers there. He stop to check if the pots are watered.";
        string str1 = str.Replace(".", "");
        string str2 = str1.Trim();
        string[] str3 = str2.Split(" ");

        for (int i = 0; i < str3.Length; i++)
        {
            char[] x = str3[i].ToCharArray();
            Array.Sort(x);
            for (int j = 0; j < str3.Length; j++)
            {
                char[] y = str3[j].ToCharArray();
                Array.Sort(y);
                if (!str3[i].Equals(str3[j]))
                {
                    if (y.SequenceEqual(x))
                    {
                        Console.WriteLine($"The anagram words are from position {i} and {j}\nThe words are {str3[i]} and {str3[j]}");
                    }
                }
            }
        }
    }
    public static void GenericListString()
    {
        List<string> alist = new List<string>();
        int count = alist.Count;
        Console.Write("Count " + count);
        Console.WriteLine(" Capacity " + alist.Capacity);
        for (int j = 0; j < 10; j++)
            alist.Add("abcd" + j);
        Console.Write("Count " + alist.Count);
        Console.WriteLine(" Capacity " + alist.Capacity);
        //for (int i = 0; i < 10; i++)
        //    alist.Add(i);
        for (int i = 0; i < count; i++)
        {
            Console.Write(alist[i] + ",");
        }
    }
    class Emp
    {
        public int ID;
        public string Name;
        public double Salary;
    }
    public static void GenericListDemoEmp()
    {
        List<Emp> empList = new List<Emp>();



        Console.Write("Length " + empList.Count);
        Console.WriteLine("\tCapacity " + empList.Capacity);
        Emp e1 = new Emp() { ID = 123, Name = "Venkat", Salary = 10000 };
        empList.Add(e1);
        empList.Add(new Emp() { ID = 456, Name = "Krishnan", Salary = 15000 });
        //empList.Add("Hello");
        Console.Write("Length " + empList.Count);
        Console.WriteLine("\tCapacity " + empList.Capacity);
        empList.Add(new Emp() { ID = 1000, Name = "Sam", Salary = 10000 });
        empList.Add(new Emp() { ID = 500, Name = "John", Salary = 10000 });
        empList.Add(new Emp() { ID = 200, Name = "Suresh", Salary = 10000 });
        empList.Add(e1);
        empList.Add(e1);



        Console.Write("Length " + empList.Count);
        Console.WriteLine("\tCapacity " + empList.Capacity);
        //IEnumerator data = empList.GetEnumerator();
        //while (data.MoveNext())
        //{
        //    Object obj = data.Current;
        //    if (obj.GetType() == typeof(Emp))
        //    {
        //        Emp e = (Emp)obj;
        //        Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e.ID, e.Name, e.Salary);
        //    }
        //    else
        //        Console.WriteLine("=======> Object is not an Employee");
        //}
        foreach (Emp e2 in empList)
        {
            Console.WriteLine("Id={0}, Name={1}, Salary={2} ", e2.ID, e2.Name, e2.Salary);
        }
    }
}