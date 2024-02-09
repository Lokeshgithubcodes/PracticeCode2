using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class PrintNoWithoutLoop
    {
        public void printNowithoutloop()
        {

            print(1, 101);
        
        }
        static void print(int start, int end) 
        {
        
            if (start < end)
            {
                Console.WriteLine(" " + start);
                print(start+1, end);
            }
        
        }
    }
}
