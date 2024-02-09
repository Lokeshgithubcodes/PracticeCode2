using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class CoversionHrToSec
    {
        public void coversionHrToSec() 
        {
            Console.WriteLine("Enter no of hrs");
            int hrs = int.Parse(Console.ReadLine());

            Console.WriteLine("Converted no of given hrs into secs " + hrs * 60 * 60);




        }
    }
}
