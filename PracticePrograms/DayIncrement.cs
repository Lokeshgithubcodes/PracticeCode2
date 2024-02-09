using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class DayIncrement
    {
        public void dayIncrement() 
        {
            Console.Write("Enter the year:");
            int yr=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month");
            int mon=int.Parse(Console.ReadLine());
            if(mon>12 || mon < 0)
            {
                Console.WriteLine("Enter the valid month");

            }
            else
            {
                Console.WriteLine("Enter the day:");
                int day=int.Parse(Console.ReadLine());
                Console.WriteLine("Next Date is");
                if(day>31 && mon==12)
                {

                    Console.WriteLine($"{yr + 1}-01-01");
                
                }
                else
                {
                    Console.WriteLine($"{yr}-{mon}-{day + 1}");
                }
            }

        
        
        
        
        }
    }
}
