using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    public class Program1
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.Write("Enter the N Number : ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of n Numbers : " + sum);
            Console.ReadLine();


        }
    }
}
