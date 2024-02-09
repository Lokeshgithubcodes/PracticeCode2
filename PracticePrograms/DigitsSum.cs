using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    class DigitsSum
    {
        public void digitsum()
        {

            Console.WriteLine("Enter no of n digits");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sum of digits you want");
            int sum = int.Parse(Console.ReadLine());
            int minValue = (int)Math.Pow(10, n - 1);
            int maxValue = (int)Math.Pow(10, n) - 1;

            for (int i = minValue; i <= maxValue; i++)
            {
                int temp = i;
                int tempSum = 0;
                while (temp != 0)
                {
                    tempSum += temp % 10;
                    temp = temp / 10;

                }
                if (tempSum == sum)
                {
                    Console.WriteLine(i);
                }
            }



        }
    }
}
