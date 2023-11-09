using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class BalancedIndex
    {
        static int FindBalancesArray(int[] arr, int size, int sum)
        {
            int leftsum = 0;
            for (int i = 0; i < size; i++)
            {
                int rightSum = sum - arr[i] - leftsum;
                if (rightSum == leftsum)
                {
                    return i;

                }
                leftsum += arr[i];

            }
            return -1;

        }
        public static void FindBalancedIndex()
        {
            int size;
            int sum = 0;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the element array");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Index of balance point = " + FindBalancesArray(arr, size, sum));
            Console.ReadKey();
        }
    }
}
