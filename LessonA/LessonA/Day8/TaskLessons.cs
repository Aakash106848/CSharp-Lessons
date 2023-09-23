using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day8
{
    class TaskLessons
    {
        public static void TestOne()
        {
            int id = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"CurrentThreadID:{id}");
            //TaskFactory tf = new TaskFactory();
            //Task t1 = tf.StartNew(ClassA.TaskMethodA);         
            //Task t2 = Task.Factory.StartNew(ClassA.TaskMethodA);
            Task t3 = new Task(ClassA.TaskMethodA);
            t3.Start();
            Task t4 = new Task(ClassA.TaskMethodA);
            t4.Start();
        }
        public static void ParentAndChild()
        {
            var parent = new Task(ClassA.ParentTask);
            Console.WriteLine("ParentStatus1: " + parent.Status);
            parent.Start();
            Console.WriteLine("ParentStatus2: " + parent.Status);
            #region A
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            Thread.Sleep(1000);
            Console.WriteLine("ParentStatus: " + parent.Status);
            #endregion
            Console.WriteLine("Test Completed");
        }
    }
}
