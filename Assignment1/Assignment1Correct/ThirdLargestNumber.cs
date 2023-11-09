using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class ThirdLargestNumber
    {
        static int getThirdLargest(int[] arr1)
        {
            int FirstLargest = arr1[0];
            int SecondLargest = int.MinValue;
            int thirdLargest = int.MinValue;
            for (int i = 1; i < arr1.Length; i++)
            {
                FirstLargest = Math.Max(FirstLargest, arr1[i]);


            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > SecondLargest && arr1[i] < FirstLargest)
                {
                    SecondLargest = arr1[i];
                }

            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > SecondLargest && arr1[i] < FirstLargest)
                {
                    SecondLargest = arr1[i];
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > thirdLargest && arr1[i] < SecondLargest)
                {
                    thirdLargest = arr1[i];
                }
            }
            if (thirdLargest == int.MinValue)
            {
                Console.WriteLine("Third largest value not exist : ");
                return int.MinValue;
            }


            return thirdLargest;


        }
        public static void print()
        {
            //int[] arr = { 12, 45, 1, 3, 67, 6, 98, 23, 14, 56 };
            int size;
            Console.WriteLine("Enter the size : ");
            int[] arr;
            int thirdLargestNumber;
            string input = Console.ReadLine();
            if (int.TryParse(input, out size))
            {
                arr = new int[size];

                // array input
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Enter the element at {0} index : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                // print
                for (int i = 0; i < size; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }


                thirdLargestNumber = getThirdLargest(arr);

                if (thirdLargestNumber != int.MinValue)
                {
                    Console.WriteLine("\nThe third largest element in the array is: " + thirdLargestNumber);
                }
            }
            else
            {
                Console.WriteLine("Invalid size input");
            }
        }
    }
}
