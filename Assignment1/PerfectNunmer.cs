using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumberProgram
{
    public class Program
    {
        
        static void Main(string[] args)
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
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Enter number is not a perfect number");
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
