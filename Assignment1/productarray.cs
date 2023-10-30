using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductArray
{
    public class Program
    {
        private static int[] PrintProduct(int[] array, int size)
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
                    ans[i] = ans[i] * array[j];

                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 3, 4};
            int size = intarray.Length;
            int[] productArray = PrintProduct(intarray, size);
            for(int i = 0; i < productArray.Length; i++)
            {
                Console.WriteLine(productArray[i]+ " "); 
            }
            //Console.WriteLine("Array with Products: " + string.Join(", ", productArray));
            Console.ReadKey();
        }
        




    }
}

