using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppCommandClass
{
    class CommandPrompt
    {
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;
        int height;
        int columns;
        string[] screenText;
        //Constructor
        public CommandPrompt (int height, int colomns)
        {
            //set the default backgroundcolor
            backgroundColor = ConsoleColor.Yellow;
            foregroundColor = ConsoleColor.Black;
            screenText = new string[height];
            Console.SetWindowSize(colomns, height + 7);

        // lets set the screen text to empty

        for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i]="";
            }
        
        }

        public void Display()
        {
            Console.BackgroundColor = backgroundColor ;
            Console.ForegroundColor = foregroundColor;
          //  Console.Clear();
            // print the screen text array text
            Console.WriteLine("********************LINE TEXT Dispayed************************");

            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }
        }
        public void SetScreenText(int lineNumber, string lineOfText)
        {
            screenText[lineNumber] = lineOfText;
        }   // end of SetScreenText method
        public void SetBackgroundColor(string color)
        {
            backgroundColor = ConvertColor(color);
        }

        public void SetForegroundColor(string color)
        {
            foregroundColor = ConvertColor(color);
        }

        public static ConsoleColor ConvertColor(string strColor)
        {
            ConsoleColor color;
            switch(strColor.ToLower())
            {
                case "black": color = ConsoleColor.Black;
                    break;
                case "red": color = ConsoleColor.Red;
                    break;
                case "blue":
                    color = ConsoleColor.Blue;
                    break;
                case "green":
                    color = ConsoleColor.Green;
                    break;
                default: color = ConsoleColor.DarkGray;
                    break;
            }
            return color;
        }
        public void ClearScreen()
        {
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }
        public void SaveScreen(String fileName)
        {
            FileStream stream;
            StreamWriter textOut = null;
            try
            {
                fileName = "C:/Projects/SD-104-CSharp/ConsoleAppCommandClass/ConsoleAppCommandClass/" + fileName;
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                textOut = new StreamWriter(stream);
                
                
              
                for (int i = 0; i < screenText.Length; i++)
                {

                   
                    textOut.WriteLine(screenText[i]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }
        
        public void ReloadScreen(String fileName)
        {
            FileStream stream;
         //  StreamReader textIn = null;

            try

            {
                fileName = "C://temp/" + fileName;

                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
               //  textIn = new StreamReader(stream);
                using (StreamReader textIn= new StreamReader(stream))
                {
                    Console.WriteLine(textIn.ReadToEnd());
                    //Console.ReadLine();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
         //       textIn.Close();
            }

        }

    }
}
