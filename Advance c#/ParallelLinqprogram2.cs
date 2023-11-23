using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ParallelLinqProgram2
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 6, 7, 5, 4, 10, 12, 13, 20, 18, 9, 11, 15, 14, 3, 8, 16, 17, 19
            };
            //Using AsOrdered Method
            //Fetching the List of Even Numbers using PLINQ
            var evenNumbers1 = numbers.AsParallel().AsOrdered().Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Even Numbers Between 1 and 20 using AsOrdered");
            foreach (var number in evenNumbers1)
            {
                Console.WriteLine(number);
            }

            //Using OrderBy Method
            //Fetching the List of Even Numbers using PLINQ
            var evenNumbers2 = numbers.AsParallel().Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            Console.WriteLine("\nEven Numbers Between 1 and 20 using OrderBy");
            foreach (var number in evenNumbers2)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}

