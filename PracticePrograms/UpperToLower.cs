using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class UpperToLower
    {
        public void upperToLower() {
            string uppercase = "LOKESH";
            string lowercase = uppercase.ToLower();

            Console.WriteLine($"uppercase: {uppercase} ");
            Console.WriteLine($"lowercase: {lowercase}");
        
        }
    }
}
