using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
/*
* File.ReadAllBytes: used when files are not stored as plain text.
* File.ReadAllLines: opens the file and reads all the lines of the file with the specified encoding.
* File.ReadAllText: Returns the contents of the text file at the specified path as a string.
* File.WriteAllBytes: it can be used in conjuction with File.ReadAllBytes.
* File.WriteAllLines: stores a string array in the specified file,overwriting the contents.
* File.WriteAllText: Writes the contents of a string to a text file.
* File.AppendAllText: Appends the specified string to the file creating the file if it doesnt already exist.
* File.AppendText
*/
namespace LessonA.Day8
{
    class FileOperator
    {
        public static void FileWriteAllLines() 
        {
            string fName = @"c:\temp\myfileA.txt";
            string[] lines = { "Chennai is the capital city.", "Madurai is the capital city.", "Salem is the steal city." };
            try
            {
                File.WriteAllLines(fName, lines);
                Console.WriteLine("File Created");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error!!!!!!"+err.Message);
            }
        }
        public static void FileReadAllText()
        {
            string line = String.Empty;
            String fName = @"c:\temp\myfileA.txt";
            line = File.ReadAllText(fName);
            Console.WriteLine(line);
        }
        public static void FileRename()
        {
            String oldfName = @"c:\temp\myfileA.txt";
            String newfName = @"c:\temp\renamedfileA.txt";
            File.Copy(oldfName, newfName);
            File.Delete(oldfName);
            Console.WriteLine("File Renamed");
        }
        public static void FileDelete()
        {
            String fName = @"c:\temp\myfileA.txt";
            if (File.Exists(fName))
                File.Delete(fName);
            else
                Console.WriteLine("File DELETE FAILED");
        }
        public static void ListDirectoryContent()
        {
            String currentDir = @"c:\temp\";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (String name in fileNames)
            {
                Console.WriteLine(name);
            }
            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*");
            foreach (String name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowCurrentDirectory()
        {
            String currentworkingdirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentworkingdirectory);
            currentworkingdirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentworkingdirectory);
        }
        public static void CreateDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Create");
            String path = @"c:\temp\" + Console.ReadLine();
            DirectoryInfo dir = Directory.CreateDirectory(path);
            Console.WriteLine("Directory Created " + dir.FullName);
        }
        public static void DeleteDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Delete");
            String path = @"c:\temp\" + Console.ReadLine();
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("Directory DELETED");
            }
            else
            {
                Console.WriteLine("Directory Not Available");
            }
        }
        public static void FileWriteAllText()
        {
            String fNameb = @"c:\temp\myfileB.txt";
            string[] lines =
            {
          "Chennai is the capital city",
          "Madurai is the Temple city",
          "Salem is the steal city"
            };
            StringBuilder sb = new StringBuilder(100);
            sb.Append(lines[0]);
            sb.Append(Environment.NewLine); // sb.Append("\\n");
            sb.Append(lines[1]);
            sb.Append(Environment.NewLine);
            sb.Append(lines[2]);
            sb.Append(Environment.NewLine);
            File.WriteAllText(fNameb, sb.ToString());
            System.Console.WriteLine("File Created");
        }
        public static void StreamWriterDemo()
        {
            String fName = @"c:\temp\myfileC.txt";
            string[] lines =
            {
          "Chennai is the capital city",
          "Madurai is the Temple city",
          "Salem is the steal city"
            };
            //  StreamWriter
            //  Write one line at a time to a file.
            //  The second String is added as a new Line.
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (string s in lines)
                {
                    sw.WriteLine(s);
                }
            }
            System.Console.WriteLine("File Created");
        }
        public static void StreamReaderFromFileDemo()
        {
            StringBuilder line = new StringBuilder(250);
            String fName = @"c:\temp\myfileA.txt";
            using (StreamReader sr = new StreamReader(fName))
            {
                line.Append(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    line.Append(sr.ReadLine());
                    line.Append(Environment.NewLine);
                }
                Console.WriteLine(line.ToString());
            }
            System.Console.WriteLine("Completed");
        }
    }
    static class ImageCache 
    {
        public static byte[] Logo 
        {
            get
            {
                byte[] _logobytes = null;
                if (_logobytes == null)
                {
                    _logobytes = File.ReadAllBytes(@"c:\temp\Html_Logo.png");
                }
                return _logobytes;
            }
            
        }
    }
}
/* use stream reader when performance matters(reading 10000+lines)and plan the use of ReadLines
 * when a file that is larger than a gb is read with system.to.file,there is a gaurenteed crash on the 32 bit version.
 * no such problems with a streamreader that reads line by line ,it will use very little memory.
 */

/* READING AN IMAGE:
 * use File.ReadAllBytes to read an image PNG to memory.
 * Can cache an image in memory for increased performance.
 * this greatly outprforms loading an image every time.
 */

/*
 * serialization:Serialization can be defined as the process of storing the state of an objectinstance to a storage medium
 * During this process ,the public and private fields of the object and the name of the class , including the asssembly containing the class , is converted to a stream of bytes , which is then written to a data stream
 * Deserialization:when an object is deserialized an exact clone of the original object is created
 * Steps In serialization:
 * A check is made to determine if the object is marked with the serializable attribute . if not , a serialization exception is thrown
 * If it is Marked appropriately,check if the object implements ISerializable .if it does , GetObjectData() is called on the object
 * If the object ldoes not implement Iserializable , the default serialization policy is used serializing all field not marked as NonSerialized.
 * A check is made to determine if the formatter has a surrogate selector. if it does ,Check the surrogate selector handles objects of the given type. if the selector handles the object type, ISerializable.GetObjectData() is called on the surrogate selector.
 * If there is no surrogate selector or if it does not handle the type , a check is made to determine if the object is marked with the serializable attribute.
 * If it is not, A serializationException is thrown.
 * Two classes used for Serialization: BinaryFormatter(convert to byte),SOAPFormatter.
 * Binary formatter: It is very efficient and produces a very compact byte stream.
 * all objects serialized with this formatter can also be deserialized with it.
 * It is important to note that constructors are not called when an object is serialized.
 */
