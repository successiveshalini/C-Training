using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegetProgram
{
    public class Program
    {
       public static int Sum(int x, int y, int z)
        { 
            return x + y + z;

        }
        public static int Sub(int x, int y)
        {
            return x - y ;

        }
        static void Main(string[] args)
        {
            Func<int, int, int, int> Add = Sum;
            int result = Add(20, 10, 40);
            Console.WriteLine(result);  
            Console.ReadKey();  
        }
    }
}
