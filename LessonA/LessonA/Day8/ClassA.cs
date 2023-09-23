using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day8
{
    class ClassA
    {
        public static void TaskMethodA() 
        {
            Console.WriteLine("Running TaskA");
            Console.WriteLine($"TaskAn ID : {Task.CurrentId} completed");
        }
        public static void TaskMethodB(Task t)
        {
            Console.Write("running TaskB");
            Console.WriteLine($" After task {t.Id} ");
            Thread.Sleep(15000);
            Console.WriteLine($"taskB id {Task.CurrentId} Completed");
        }
        public static void TaskMethodC(Task t)
        {
            Console.Write("running TaskC");
            Console.WriteLine(" After task {0} ", t.Id);
            Thread.Sleep(1000);
            Console.WriteLine("taskC id {0} Completed", Task.CurrentId);
        }
        public static void TaskMethodB1(Task t)
        {
            Console.Write("running TaskB1");
            Console.WriteLine(" After task {0} ", t.Id);
            Console.WriteLine("taskB1 id {0} Completed", Task.CurrentId);
        }
        public static void ContinueTask()
        {
            Task t1 = new Task(ClassA.TaskMethodA);
            Task t2 = t1.ContinueWith(ClassA.TaskMethodB);
            Task t3 = t1.ContinueWith(ClassA.TaskMethodC);
            Task t4 = t2.ContinueWith(ClassA.TaskMethodB1);
            t1.Start();
            //Task.WaitAll(t1,t2,t3,t4);
            
            Console.WriteLine("Bye from ContinueTask");
        }
        public static void ParentTask()
        {
            Console.WriteLine("Inside parentTask ");
            Console.WriteLine($"ParentTask id {Task.CurrentId}");
            var child = new Task(ChildTask, TaskCreationOptions.AttachedToParent);
            child.Start();
            Console.WriteLine("parent has started child");
            Thread.Sleep(3000);
        }
        public static void ChildTask()
        {
            Console.WriteLine("child started");
            Console.WriteLine($"childTask id {Task.CurrentId}");
            Thread.Sleep(10000);
            Console.WriteLine("child finished");
        }
        public static int GenerateNumbers(CancellationToken ct)
        {
            int i;
            for (i = 0; i < 1000; i++)
            {
                Console.WriteLine("Method1 - Number: {0}", i);
                Thread.Sleep(1000);
                // poll the IsCancellationRequested property
                // to check if cancellation was requested
                if (ct.IsCancellationRequested)
                {
                    break;
                }
            }
            return i;
        }
        // Notify when task is cancelled
        public static void CancelNotification()
        {
            Console.WriteLine("Cancellation request made!!");
        }
        public static void TestCancelToken()
        {
            Console.WriteLine("Press 1 to cancel task");
            var cTokenSource = new CancellationTokenSource();
            var cToken = cTokenSource.Token;
            var t1 = Task<int>.Factory.StartNew(
                () => ClassA.GenerateNumbers(cToken), cToken);
            // to register a delegate for a callback when a 
            // cancellation request is made
            cToken.Register(ClassA.CancelNotification);
            // If user presses 1, request cancellation.
            if (Console.ReadKey().KeyChar == '1')
            {
                cTokenSource.Cancel();
            }
        }
    }
}
/* Syste,.Threading.Tasks
 * A task is a unit of work to be done in a seperate thread
 * Wrapper for threadpool(collection of threads)
 * thread: background(demon: waits for the threads to be free),foreground
 * 
 * Creating a Task : 3 ways;;;;;;;;;;;;;;;;;;;;;m = functional pointer(delegate)
 * TaskFactory tf = new TaskFactort();
 * Task t1 = ts.StartNew(m1);
 * or
 * task t2 = Task.Factory.StartNew(m2);
 * or
 * Task t3 = new Task()
 * t3.Start();
 * Task Heirarchies:
 * With task Continuations the task form a Heirarchies 
 * when a task Starts a new task a parent child heirarchy is started 
 * When parent class is stopped ,the child task also stops.
 * Task Status : Created , WaitingForActivation,WaitingForRun,Runnning,WaitingForChildrenToComplete,RanToCompletion,Cancelled,Faulted
 */