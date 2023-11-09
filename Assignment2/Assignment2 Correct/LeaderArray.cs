using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class LeaderArray
    {
        public static int FindLeadersArray(int[] array)
        {
            int count = 1;
            int rightMax = array[array.Length - 1];
            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (rightMax < array[i])
                {
                    rightMax = array[i];
                    count++;
                }

            }
            return count;

        }

        public static void CountLeader()
        {
            int size;
            Console.WriteLine("Enter the size of array:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Format("Enter the element {0} index:", i));
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            //Console.WriteLine("\n the arr is: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(string.Format("{0} ", arr[i]));


            }
            int count = FindLeadersArray(arr);
            Console.WriteLine("\nThe Leader is : " + count);


        }
    }
    
    
}


