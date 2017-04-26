using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {

            bool displayMenu = true;
            while (displayMenu)
            {

                displayMenu = MainMenu();

            }


        }

        public static bool MainMenu()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Show Countries");
            Console.WriteLine("2) Add a Country");
            Console.WriteLine("3) Delete a country");
            Console.WriteLine("4) Ouit");

            

            int userInput = Validate.RangeValidator(1, 3);

            if (userInput == 1)
            {

                Console.WriteLine(ReadFromFile()); 

                Console.WriteLine("option 1");
                return true;
            }
            else if (userInput == 2)
            {

                string countries = Console.ReadLine();

                WriteToFile(countries);

                Console.WriteLine("option 2");
                return true;
            }

            else if (userInput == 3)
            {
                Console.WriteLine("delete a country");
            }

            else if (userInput == 4)
            {
                Console.WriteLine("quit");
                return false;
            }

            else
            {
                return true;
            }

        }

        public static void WriteToFile(string input)
        {
            StreamWriter sw = new StreamWriter("../../World.txt", true); //settings.txt use relative path, relative to exe.
            sw.WriteLine(input);
            sw.Close(); //resource management, close so others can use it

        }

        public static string ReadFromFile()
        {
            StreamReader rd = new StreamReader("../../World.txt ");

            string FileContent = rd.ReadToEnd();

            rd.Close();
            return FileContent;

        }



    }
}
