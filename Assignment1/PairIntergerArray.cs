using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairIntegerArray
{
    public class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 1, 3, 6 };
            List<int[]> ans = new List<int[]>();
            int sz = arr.Length;
            int target = 5;
            for (int i = 0; i < sz; i++)
            {

                for (int j = i + 1; j < sz; j++)
                {
                    if (arr[i] + arr[j] < target)
                    {
                        int[] temp = new int[2];
                        temp[0] = i;
                        temp[1] = j;
                        ans.Add(temp);

                    }


                }

            }

            foreach (var val in ans)
            {
                Console.WriteLine(val[0] + " " + val[1]);

            }
            Console.ReadKey();



        }
    }

}
