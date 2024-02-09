using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class PrimeNumber
    {
        public void prime()
        {
            Console.WriteLine("Enter no.of elements in array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Elements");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int k in arr)
            {
                if (prime(k))
                {
                    Console.Write(k+" ");
                }
            }

        }

        public void print()
        {
            for (int m = 1; m < 100; m++)
            {
                if (prime(m))
                {
                    Console.WriteLine(m);
                }
            }
        }
        static bool prime(int j)
        {
            int k1 = 2;
            if (j <= 1)
            {
                return false;
            }
            if (j == 2)
            {
                return true;
            }
            else
            {
                while (k1<=j)
                {
                    if (j % k1 == 0)
                    {
                        return false;
                    }
                    k1++;
                }
                return true;

            }
        }
    }
}
