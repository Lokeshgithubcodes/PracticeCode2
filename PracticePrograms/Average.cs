using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    class Average
    {
        public void average() 
        {
            // Create a Random object for generating random numbers
            Random random = new Random();

            // Generate 5 random numbers between 10 and 50
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = random.Next(10, 51);
            }

            // Print the generated numbers in one line
            for(int i =0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Calculate the average of the generated numbers
            double average = CalculateAverage(numbers);

            // Print the average in the next line
            Console.WriteLine("Average: " + average);
        }

        static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0.0;
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;

        }
    }
}
