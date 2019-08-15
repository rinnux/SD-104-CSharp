using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleAppStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

        //  Stream myStream;
        //   myStream = null;

         //Step 1
         //  FileStream myFileStream = new FileStream("TestFile1.txt", FileMode.Open, FileAccess.Read);
            FileStream myFileStream = new FileStream("C:/Projects/SD-104-CSharp/ConsoleAppStreamReader/ConsoleAppStreamReader/TestFile1.txt", FileMode.Open, FileAccess.Read);

         //Step2
            StreamReader myFileReader = new StreamReader(myFileStream);
         //Step3
            Console.WriteLine(myFileReader.ReadLine());
            Console.ReadLine();
        }
    }
}
