using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class Factorial
    {
        public void factorial() 
        {
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            int f = 1;
            for(int i=1;i<=n;i++)
            {
                f=f*i;
                
                
            }

            Console.WriteLine(f);

        }
    }
}
