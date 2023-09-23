using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal abstract class Vehicle
    {
        public Vehicle() 
        {
            Console.WriteLine("VEHICLE CREATED");
        }
        public void start() 
        {
            Console.WriteLine("Vehicle Started");
        }
    }
    internal class Car : Vehicle 
    {
        public Car() 
        {
            Console.WriteLine("car has been constructed");
        }
    }
    class VehicleTester() 
    {
        public static void TestOne() 
        {
            Vehicle Tester = new Car();
            Tester.start();
        }
    }
}
