using LessonA.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*input devices
 * output devices
 * input stream to receive array of byte to object decoding.
 * output stream to send objects in the form of array of bytes encoding.
 * A stream is an abstraction that either produces or consumes information.
 * a stream is linked to a physical device by the i/o system.
 * All streams behave in the same manner , even if the actual physical devices they are linked to differ.
 * Thus the i/0 classes and methods can be applied to many types of devices.
 * the same methods that you use to write to console can also be used to write a disk file.
 * input stream/ output stream.
 * stream types : byte stream(data transfer) => character stream and Binary stream.
 * Many devices are byte oriented when it comes to i/o operations. 
 * at the lowest level all c# i/o operates on bytes.
 * in c# char is 16 bit-type and byte is an 8 bit-type.
 * if the asscii character set is used  then it is easy to convert between bytes and characters.just ignore the higher order byte of the char value.
 * But this wont work for the rest of the unicode characters.
 * thus byte streams are not perfectly suited for handling character based i/o.
 * to solve this problem dot.net framework defines several classes that convert a byte stream into a character stream ,handling translation of byte to char or char to byte automatically.
 * stream -<abstract class> 
 * child classes that use this abstract class : BufferedStream,FileStream,MemoryStream,UnManagedMemoryStream
 * */
namespace LessonA.Day8
{
    class StreamLesson
    {
        public static void Test1() 
        {
            char ch;
            Console.WriteLine("PRESS A KEY FOLLOWED BY ENTER");
            int x = Console.Read();
            //FROM TEXTREADER ABSTRACT CLASS
            ch = (char)x;
            Console.WriteLine("\n"+x+"YOUR KEY IS : "+ch);
        }
        public static void Test2()
        {
            char ch = ' ';
            Console.WriteLine("PRESS q to EXIT");
            while (ch != 'q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your key is : " + ch);
            }
        }
        public static void Test3() 
        {
            Console.Out.WriteLine("Enter a sentence : ");
            string? str = Console.ReadLine();
            Console.Out.WriteLine(" "+str);
        }
        //nullable type exists if ? follows the type
        public static void TestNullables()
        {
            int? x = 700;
            x = null;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else 
            {
                Console.WriteLine(x.GetValueOrDefault());
            }
        }
    }
}
/*
 * memory stream represents a stream in a memory.
 * There are Two ways to  create a memory stream: inintialize one from an unassigned byte array or you can create an empty one.
 * Empty memory streams are resizable ,while the ones created with a byte array provides a stream "view" of the data.
 */

/*
 * Binary reader and binary writer for reading and writing primitive data types as binary values
 * Text reader and Text writer are an abstract class .
 * Used for reading and writing characters by using an encoding values to convery the characters to and from bytes.
 * Stream reader and stream writer used for reading and writing characters to and from strings
 * string reader and awriter
 */

/*
 * paragraph(string) to array of bytes:  byte[] dataArray = System.Text.Encoding.ASCII.GetBytes(inputData);
 * conversion of byte array to string:  byte[] verifyArray = binReader.ReadBytes(arrayLength);
                                        String stringOutput = Encoding.ASCII.GetString(verifyArray);
 */
