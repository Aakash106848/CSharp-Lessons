//using System.Runtime.InteropServices;
//using System.Text;

//class tryloop
//{
//    public static void TestMultipleNestedTry()
//    {
//        try // try1
//        {
//            try // try2
//            {
//                try //try3
//                {
//                    try //try4
//                    {
//                        throw new Exception("bla bla");
//                    }
//                    catch (Exception ex0)
//                    {
//                        throw new ApplicationException("ex0" + ex0.Message);
//                    }//end of try4
//                }
//                catch (ApplicationException ex1)
//                {
//                    throw new IndexOutOfRangeException("ex1" + ex1.Message);
//                }
//                catch (Exception ex2)
//                {
//                    throw new Exception("ex2" + ex2.Message);
//                }//end of try3
//            }
//            catch (ApplicationException ex3)
//            {
//                throw new DllNotFoundException("ex3" + ex3.Message);
//            }
//            catch (IndexOutOfRangeException ex4)
//            {
//                throw new ArgumentNullException("ex4" + ex4.Message);
//            }
//            catch (Exception ex5)
//            {
//                throw new Exception("ex5" + ex5.Message);
//            }// end of try2
//        }
//        catch (ApplicationException ex6)
//        {
//            throw new ArgumentNullException("ex6" + ex6.Message);
//        }
//        catch (DllNotFoundException ex7)
//        {
//            throw new DllNotFoundException("ex7" + ex7.Message);
//        }
//        catch (ArgumentNullException ex8)
//        {
//            throw new ArgumentNullException("ex8" + ex8.Message);
//        }
//        catch (Exception ex9)
//        {
//            throw new ArgumentNullException("ex9" + ex9.Message);
//        }// end of try1
//    }
//}
//public class Test
//{

//    // What are Value types? Declare a variable for each Value type, and print its Max Value.

//    /**

//      * Value types are predefined datatypes in C#

//      * Value types are loaded in the stack

//      * Value types need not be instantiated

//      * Value types have default value

//      * Value types can not be set to NULL

//      * Value types contain value in the memory allocated to them

//      * When a value type is assigned to another value type a copy of the value will be created

//      * Struct and Enums are Value types

//      */
//    public static void QuestionOne()

//    {

//        byte byteOne = 1;

//        sbyte sbyteOne = 1;

//        short shortOne = 1;

//        int intOne = 1;

//        long longOne = 1;

//        float floatOne = 1.543f;

//        double doubleOne = 2345.76534d;

//        decimal decimalOne = 627637263.36263726372M;

//        char charOne = 'A';

//        bool boolOne = true;

//        Console.WriteLine(byte.MaxValue);

//        Console.WriteLine(sbyte.MaxValue);

//        Console.WriteLine(short.MaxValue);

//        Console.WriteLine(int.MaxValue);

//        Console.WriteLine(long.MaxValue);

//        Console.WriteLine(float.MaxValue);

//        Console.WriteLine(double.MaxValue);

//        Console.WriteLine(decimal.MaxValue);

//    }
//    /***
//  * What are Global variables, and what are local variables? Give an example
//  * Variables Declared at the class level are global Variables.
//  * Global Variables can be accessed in all the methods of the class.
//  * Local Variables are declared with in a method.
//  * The scope of the local Variable is limited to the block in which it is declared
//  */

//    public static void Question3a()
//    {
//        string strfriend = "Tom and jerry are friends";
//        string[] array = strfriend.Split(" ");
//        int length = array.Length;
//        Console.WriteLine("no. of words" + length);
//    }
//    //  Write a function that can reverse the string
//    public static void QuestionThreeB()
//    {
//        String strFriends = "Tom and Jerry are good friends";
//        Console.WriteLine(strFriends);
//        // first Method
//        char[] charData = strFriends.ToCharArray();
//        int len = charData.Length;
//        StringBuilder sb = new StringBuilder(len + 10);
//        for (int i = len - 1; i >= 0; i--)
//        {
//            sb.Append(charData[i]);
//        }
//        Console.WriteLine(sb.ToString());
//        // Second Method
//        var strReverse = strFriends.Reverse();
//        foreach (var item in strReverse)
//        {
//            Console.Write(item);
//        }
//    }


//    // Write a function that counts the no of characters in the string 

//    public static void QuestionThreeC()

//    {

//        String strFriends = "Tom and Jerry are good friends";

//        Console.WriteLine($"Char Count: {strFriends.Length} ");

//    }

//    // Change the string to Uppercase and print

//    public static void QuestionThreeD()

//    {

//        String strFriends = "Tom and Jerry are good friends";

//        string strInUpper = strFriends.ToUpper();

//        Console.WriteLine(strFriends);

//        Console.WriteLine(strInUpper);

//    }
//    //Print from 10th char to the 15th char
//    public static void QuestionThreeE()
//    {
//        String strFriends = "Tom and Jerry are good friends";
//        String strPart = strFriends.Substring(10, 5);
//        Console.WriteLine(strFriends);
//        Console.WriteLine(strPart);
//    }
//    // How will you check if the input name contains only alphabets,
//    // and the length of the name is not less than 8 characters?
//    public static void QuestionFour()
//    {
//        Console.WriteLine("Enter a NAME");
//        String name = $"{Console.ReadLine()}";
//        int len = name.Trim().Length;
//        if (len < 8)
//        {
//            String errorMessage = "Name is Lessthan 8 Char. Try Again...";
//            throw new Exception(errorMessage);
//        }
//        char[] nameCharArray = name.Trim().ToUpper().ToCharArray();
//        foreach (var item in nameCharArray)
//        {
//            int asciiValue = item;
//            if (asciiValue < 65 || asciiValue > 90)
//            {
//                String errorMessage = "Name Must contain ONLY Alphabets. Try Again...";
//                throw new Exception(errorMessage);
//            }
//        }
//        Console.WriteLine($"Correct Input {name}");
//    }
//    //What are the essential differences between C# consts, Static, and readonly fields? 
//    /**
//    * For Constant Fields a Value must be assigned on declaration
//    * Constant value can not be changed
//    * Static Value need not be assigned on declaration
//    * Static Value can be changed
//    * An Object for the class need not be created for Static, and Constants
//    * Static, and Constants can be accessed using [ClassName.FieldName]
//    * Constants, and Static Fields are loaded in the stack, and shared 
//    * 
//    * For readonly fields value can be assigned only through the constructor
//    * Readonly Field can be accessed only through a reference
//    * ReadOnly Fields can not be modified after a value is assigned
//    * Different instances of the class can have different value for Readonly field
//    * Readonly fields are not shared
//*/
    


        


//    }
