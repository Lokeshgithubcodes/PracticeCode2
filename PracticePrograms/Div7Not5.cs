using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class Div7Not5
    {
        public void div7Not5() 
        {
            for (int i=2000;i<=3200;i++) 
            {
                if(i%7==0 && i%5!=0)
                {
                    Console.Write(i+",");
                }
            
            
            
            } 
        
        
        
        }
    }
}
