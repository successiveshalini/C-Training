using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class PerfectNumberProgram1
    {
        public static void FindPerfectNumber()
        {
            int number, sum = 0, n;
            Console.Write("enter the Number");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(" Enter number is a perfect number");
            }
            else
            {
                Console.WriteLine(" Enter number is not a perfect number");
            }
            
        }

    }
}
