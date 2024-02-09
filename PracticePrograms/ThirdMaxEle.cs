using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class ThirdMaxEle
    {
        public void thirdMaxEle() 
        {
            Console.WriteLine("Enter the size of Array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements");
            for(int i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Third max Elements is");
            Console.WriteLine(arr[n - 3]);
        }
    }
}
