using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class Circle
    {
        public void circle() 
        {
            Console.WriteLine("Enter the diameter of the circle");
            double dia=double.Parse(Console.ReadLine());
            double perimeter = 2 * 3.14 * dia/2;
            Console.WriteLine("The perimeter is: " + perimeter);
            double area = 3.14 * dia/2 * dia/2;
            Console.WriteLine("The area is: " + area);

        
        
        
        }
    }
}
