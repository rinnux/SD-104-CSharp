using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPrompt myCommand = new CommandPrompt(20,25);
            myCommand.SetScreenText(2, "This line 2 text");
            myCommand.SetScreenText(1, "This line 1 text");
            myCommand.SetScreenText(4, "At Line 4");
            myCommand.SetScreenText(11, "At Line 11");
            myCommand.Display();
            Console.ReadLine();
        }
    }
}
