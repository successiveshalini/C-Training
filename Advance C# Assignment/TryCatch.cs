1) Write a small program where you need to implement a Try and Catch Block . 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchPrograms
{
    public class Program
    {
         public static void SomeMethod()
        {
            int[] arr = { 10, 0, 20, 30, 40, 50 };
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);

                 }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An Exception has occurred : {0}", ex.Message);
            }

        }

        static void Main(string[] args)
        {
            SomeMethod();

            Console.ReadKey();        
        }
    }
}
