using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelLinqProgram
{
    public class Program
    {

        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 40);
            //var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();  
            
            var evenNumbers = numbers.AsParallel().Where(x => x % 2 == 0).ToList(); 
            Console.WriteLine("Even Numbers Between 1 and 40");
            foreach (var number in evenNumbers)
            { 
                Console.WriteLine(number);  
                Console.ReadKey();  

            }
            
            
        }
    }
}
