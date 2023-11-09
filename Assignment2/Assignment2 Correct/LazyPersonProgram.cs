using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class LazyPersonProgram
    {
        public static void Find(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                    continue;
                else
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == 0)
                            arr[j] = 1;
                        else
                            arr[j] = 0;

                    }
                }
                count++;


            }
            Console.WriteLine();
            Console.WriteLine("Minimum number of switch a person : {0}" + count);

        }
        public static void LazyPerson()
        {
            int size;
            Console.WriteLine("Enter the size of arr :");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Format("Enter element at index {0} : ", i));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(" {0} ", arr[i]);

            }
            Find(arr);
        }
    }
}
