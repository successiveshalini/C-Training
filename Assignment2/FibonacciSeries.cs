using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesProgram
{
    public class Program
    {
        private static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n-2);

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Fibonacci Series: ");
            int count = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(Fibonacci(i) + " ", count);
            }

            Console.ReadLine();
        }
    }
}
