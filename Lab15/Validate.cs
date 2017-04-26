using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Validate
    {

        public static int RangeValidator(int min, int max)

        {

            int input;

            //Console.WriteLine($"Please enter an Integer between {min} and {max}");

            input = GetValidInteger();

            while (input < min || input > max)

            {

                Console.WriteLine("Wrong input! please enter number within range!");

                input = GetValidInteger();

            }

            return input;



        }

        public static int GetValidInteger()
        {
            int input;

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("This is not a integer, please enter a integer");
            }
            return input;
        }



    }
}
