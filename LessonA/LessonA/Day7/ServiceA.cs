using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day7
{
    class ServiceA
    {
        int x = 0;
        public void DoTask() 
        {
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.Write("Inside DoTaskA");
            Console.WriteLine("\t Thread ID: "+ id);
            //int x = 0;
            try
            {
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("ID: " + id + "X= " + x + " i=" + icount);
                    Thread.Sleep(1000);//1s=1000ms
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
}
