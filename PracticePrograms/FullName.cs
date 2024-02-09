using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class FullName
    {
        public void fullname() 
        {
            //Enter the Person's Full Name
            Console.WriteLine("Enter the firstname;");
            string firstname=Console.ReadLine();
            Console.WriteLine("Enter the lastname");
            string lastname=Console.ReadLine();
            Console.WriteLine($"Firstname:{firstname} Lastname:{lastname}");
        
        
        
        }
    }
}
