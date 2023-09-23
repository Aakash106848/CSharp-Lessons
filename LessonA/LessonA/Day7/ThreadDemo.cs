using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace LessonA.Day7
{
    internal class ThreadDemo
    {
        public static void DemoCurrentThread() 
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID = "+id);
            Console.WriteLine("IsAlice = "+t1.IsAlive);
            Console.WriteLine("Priority = " + t1.Priority);
            Console.WriteLine("ThreadStates = " + t1.ThreadState);
            Console.WriteLine("CurrentCulture = " + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture = " +t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("ta");
            Console.WriteLine("CurrentCulture = " + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        //single thread
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;

            int id = t.ManagedThreadId;
            Console.WriteLine("MainThreadID : " + id);
            ServiceA a1 = new ServiceA();
            a1.DoTask();

        }
        //multiple thread
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainThreadID : " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTask);
            t1.Start();
            a1.DoTask();
            Console.WriteLine("----------End Of DemoB----------");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainThreadID : " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTask);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId+"T1 STATE"+t1.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t1.ManagedThreadId + "T1 STATE  AFTER SLEEP  " + t1.ThreadState);
            Console.WriteLine("----------End Of DemoB----------");
        }
        public static void DemoC() 
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainThreadID : "+id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = new ThreadStart(a1.DoTask);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(7000);
            if (t1.IsAlive)
            t2.Join(7000);
            if (t2.IsAlive)
            Console.WriteLine("----------End Of Democ----------");
        }
        //public static void DemoD() 
        //{
        //    Thread t = Thread.CurrentThread;=
        //}
    }
}
