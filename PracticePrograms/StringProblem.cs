using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class StringProblem
    {
        public void stringProblem() 
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string result = ConvertNumberToString(number);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        static string ConvertNumberToString(int number)
        {
            string result = "";

            if (number % 3 == 0)
            {
                result += "Pling";
            }

            if (number % 5 == 0)
            {
                result += "Plang";
            }

            if (number % 7 == 0)
            {
                result += "Plong";
            }

            // If the number has none of the factors, pass its digits straight through
            if (string.IsNullOrEmpty(result))
            {
                result = number.ToString();
            }

            return result;





        }
    }
}
