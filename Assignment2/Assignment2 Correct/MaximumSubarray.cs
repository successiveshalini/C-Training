using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class MaximumSubarray
    {
        public static void FindMaximumSubarray(int[] arr)
        {
            int maxi = int.MinValue;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                maxi = Math.Max(sum, maxi);
                if (sum < 0)
                    sum = 0;


            }
            Console.WriteLine();
            Console.WriteLine("Maximum Subarray sum is {0}", maxi);

        }
        public static void MaxSubarray()
        {
            int size;
            Console.Write("Enter the size of arr:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Format("Enter the element {0} index:", i));
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < arr.Length; i++)

            {
                Console.Write("{0}", arr[i]);

            }

        }

    }

}
