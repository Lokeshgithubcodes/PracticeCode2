using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class Square
    {
        public void square() {
            Console.WriteLine("Enter First Number");
            Double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            Double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Sum Of Square Of given two numbers are");
            Console.WriteLine(a * a + b * b);
            Console.WriteLine("Differnece of Square of given two numbers are");
            Console.WriteLine(a * a - b * b);

         


        }
    }
}
