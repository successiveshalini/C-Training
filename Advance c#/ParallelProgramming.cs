using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# For LOOP");
            int number = 10;
            for (int count = 0; count < number; count++)
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10); 
            
            }
            Console.WriteLine();
            Console.WriteLine("Parallel C# For Loop");
            Parallel.For(0, number, count =>
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                
                Thread.Sleep(10);
            });
            Console.ReadKey();  
        }
        
    }
}
