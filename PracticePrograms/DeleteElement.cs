using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     class DeleteElement
    {
        public void deleteElement() 
        {
            Console.WriteLine("Enter number of Elements");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Enter the pos");
            int pos = int.Parse(Console.ReadLine());
            DeleteElementAtIndex(ref arr, pos);
            Console.WriteLine("The new list is : " + string.Join(" ", arr));
        }
        static void DeleteElementAtIndex(ref int[] arr, int position)
        {
            // Shift elements to the left starting from the position to delete
            for (int i = position - 1; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            // Resize the array to remove the last element
            Array.Resize(ref arr, arr.Length - 1);


        }
    }
}
