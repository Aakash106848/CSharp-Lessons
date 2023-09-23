public delegate void MethodHandlerA();
public delegate int MethodHandlerB(int x,int y);
public class MathCalculator
{
    public void DoTask() 
    {
        Console.WriteLine("Calculator DoTask");
    }
    public int Add(int x , int y) 
    {
        Console.WriteLine(x + "," + y);
        return x + y;
    } 
    public int Multiply (int x, int y) 
    {
        Console.WriteLine(x + "," + y);
        return (int)x * y;

    }
    public int Divide(double x, double y) 
    {
        Console.WriteLine(x +","+ y);
        return (int)(x / y);
    }
    public class DelegateDemo 
    {
        public static void TestOne() 
        {
            MathCalculator mc = new MathCalculator();
            MethodHandlerA methodHandlerA = new MethodHandlerA(mc.DoTask);
            MethodHandlerB methodHandlerB = new MethodHandlerB(mc.Add);
            MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Multiply);
            methodHandlerA();
            int addResult = methodHandlerB(100, 50);
            Console.WriteLine(addResult);
            int multiplyResult = methodHandlerTwo(20, 5);
            Console.WriteLine(multiplyResult);

        }
    }
}
//types of delegates ,when to use which delegate provided with code example 
//2 types
// single cast delegate , multicast delegate
// points to single method ...points to multiple methods
//methods with multicasts are not suitable for typecasting 
//All events are multi cast delegates
// event is an action when a data is modified
