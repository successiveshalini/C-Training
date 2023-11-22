using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parallelForLoopProgramming
{
 public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# parallel For Loop");
            Parallel.For(1, 11, number => {
                Console.WriteLine(number);
            });
            Console.ReadKey();  
        }
    }
}
