using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class CountofChar
    {
        static int countchar(string input) 
        {
            int characterCount = 0;
            foreach (char c in input) 
            {
                if (char.IsLetter(c))
                {
                    characterCount++;
                }
            }
            return characterCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string input= Console.ReadLine();
            int characterCount= countchar(input);
            Console.WriteLine("Number of char in iputs:" + characterCount);
        }
    }
    
}
