using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class ShiftingZeros
    {
        public void shiftingZeros() 
        {

            int[] arr = { 12, 0, 4, 24, 0, 4 };
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
            Console.WriteLine(string.Join(", ", arr));




        }
    }
}
