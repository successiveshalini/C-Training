using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class FindPairsProgram
    {
        public static void ShowPairs(int[] arr, int size, int targetsum)
        {
            Console.WriteLine("Pairs with sum less sum" + targetsum + ":");
            bool flag = false;
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[i] + arr[j] < targetsum)
                    {
                        flag = false;
                        Console.WriteLine("[{0},{1}] with indices ({2},{3})", arr[i], arr[j], i, j);

                    }

                }

            }
            if (!flag)
            {
                Console.WriteLine("No Pairs Found!!");
            }

        }
        public static void FindPairs()
        {
            int size;
            Console.Write("Enter the size of arr : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("Enter element at index {0} : ", i));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("/n arr is : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            int target;
            Console.WriteLine("/n/n Enter your target value : ");
            target = Convert.ToInt32(Console.ReadLine());
            ShowPairs(arr, size, target);
        }
    }

   }

