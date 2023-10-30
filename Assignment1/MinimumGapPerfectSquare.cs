using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumGapForPerfectSquare
{
    public class Program
    {
        public static bool IsPerfectSquare(int num)
        { 
            return Math.Ceiling(Math.Sqrt(num)) == Math.Floor(Math.Sqrt(num));    
        }
        private static int Solve(int num)
        {
            if (IsPerfectSquare(num))
            {
                return 0;

            }
            int high, low;
            int temp = num + 1;
            while (true)
            {
                if (IsPerfectSquare(temp))
                { 
                    high = temp;
                    break;
                }
                temp++; 

            }
            temp = num -1;
            while (true)
            {
                if (IsPerfectSquare(temp))
                { 
                    low = temp;
                    break;  
                }
                temp--;
                    
            }
            return Math.Min(high - num, num - low);

        }
        static void Main(string[] args)
        {
           
            int num;
            Console.WriteLine("Enter a Number:");
            num = Convert.ToInt32(Console.ReadLine());

            int ans = Solve(num);
            Console.WriteLine(string.Format("The Minimum gap is {0}", ans));
            Console.ReadKey();


        } 
    }
}
