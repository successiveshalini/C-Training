using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProgram2
{
    public class Program
    {
        public static void Method()
        {
            int a = 7;
            int b = 0;
            try
            {
                int c = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void Main(string[] args)
        {
            Method();
            Console.ReadKey();

        }
    }
}
