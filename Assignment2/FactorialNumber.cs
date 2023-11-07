using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumberProgram
{
    public class Program
    {
        public  int Factorial(int num)
        {
            if (num == 0)
                return 1;
            else
            return num * Factorial(num - 1);    

        }
        static void Main(string[] args)
        {
            int Fact, num;
            Console.WriteLine("Enter a Number");
            num = Convert.ToInt32(Console.ReadLine()); 
            Program obj = new Program();
            Fact = obj.Factorial(num);
            Console.WriteLine("Factorial of {0} is {1}", num, Fact);
            Console.ReadKey();
        }
    }
}
