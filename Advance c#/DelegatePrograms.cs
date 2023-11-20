using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegetPrograms1
{
    public class Program
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public delegate void mulnum(int a, int b); 
        public delegate void divnum(int a, int b);  
           
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }
        public void multiply(int a, int b)
        {
            Console.WriteLine("(20 * 6) = {0}", a * b);
        }
        public void division(int a, int b)
        {
            Console.WriteLine("(100 % 20) = {0}", a % b);
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            addnum del1 = new addnum(obj.sum);
            subnum del2 = new subnum(obj.subtract);
            mulnum del3 = new mulnum(obj.multiply);
            divnum del4 = new divnum(obj.division);
            
            del1(100, 40);
            del2(100, 60);
            del3(20, 6);
            del4(100, 20);
            Console.ReadKey();
            
        }
        
    }
}
