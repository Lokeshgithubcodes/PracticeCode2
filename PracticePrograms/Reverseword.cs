using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class Reverseword
    {
        public void reverseword() 
        {

            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            string[] arr = s.Split(" ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }


        }
    }
}
