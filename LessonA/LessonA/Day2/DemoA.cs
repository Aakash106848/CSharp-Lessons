using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day2
{
    internal class DemoA
    {
        //GLOBAL DECLARATION
        int x = 123; //MEMBER VARIABLE,FIELD,CLASS VARIABLE
        //METHOD CAN ONLY BE CREATED INSIDE A CLASS
        static int y = 123;
        // ONLY VARIABLE DECLARATION OUTSIDE A METHOD
        public static void FirstMethod()
        {
            //LOCAL VARIABLE DECLARATION
            //SAME NAME FOR LOCAL AND GLOBAL VARIABLE IS POSSIBLE
            //int x = 1000;
            int y = 2000;
            // STATIC VARIABLES CAN BE ACCESSED INSIDE A STATIC METHOD,BUT NON STATIC VARIABLES CANNOT BE ACCESSED
            Console.WriteLine(DemoA.y);// GLOBAL VARIABLE Y
            Console.WriteLine(y);//LOCAL VARIABLE Y
            //Console.WriteLine(x);//NOT POSSIBLE
        }
        public void SecondMethod() 
        {
            int y = 2000;
            Console.WriteLine(DemoA.y);//GLOBAL VARIABLE Y
            Console.WriteLine(y);//LOCAL VARIABLE Y
            Console.WriteLine(x);//NON STATIC VARIABLE CAN BE CALLED BY NON STATIC METHOD
        }
        public static void TestMethod() 
        {
            DemoA.FirstMethod();
            //DemoA.SecondMethod(); non static method cannot be called
            //OBJECT CREATION
            DemoA demoA_obj = new DemoA();
            //CALLING NON STATIC METHOD
            demoA_obj.SecondMethod();
        }
    }
    internal class DemoB
    {
    }
}
namespace LessonA.Gavs
{
    internal class DemoA
    {

    }
}