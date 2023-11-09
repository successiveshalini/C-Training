using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class ProductArrayProgram
    {
        private static int[] PrintProduct(int[] arr, int size)
        {
            int[] ans = new int[size];
            for (int i = 0; i < size; i++)
            {
                ans[i] = 1;
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        continue;

                    }
                    ans[i] = ans[i] * arr[j];

                }

            }
            return ans;

        }
        public static void print()
        {
            int[] intarr = { 1, 2, 3, 4 };
            int size = intarr.Length;
            int[] productArray = PrintProduct(intarr, size);
            for (int i = 0; i < productArray.Length; i++)
            {
                Console.WriteLine(productArray[i] + " ");
            }
            Console.WriteLine("Array with Products: " + string.Join(", ", productArray));
        }
            
    }
}
