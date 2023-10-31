using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArray
{
    public class Program
    {
        static int ThirdLargestNumber(int[] arr1)
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
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 1, 3, 67, 6, 98, 23, 14, 56 };
            int thirdLargestNumber = ThirdLargestNumber(arr);

            if (thirdLargestNumber != int.MinValue)
            {
                Console.WriteLine("The third largest element in the array is: " + thirdLargestNumber);
            }
            Console.ReadKey();
        }
    }
}

