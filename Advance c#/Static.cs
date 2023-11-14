using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structureprogrm
{
    public class Static
    {
        static Demo()
        {
            staticReadOnlyVal = "Value can be changed here";
            staticReadOnlyVal1 = "Value can be changed here 1";
        }
    }
    class Program
    {
        public Program()
        {
            Demo.staticVal = "Changed here in Program Constructor";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Demo.staticVal);
            Console.WriteLine(Demo.staticVal1);
            Console.WriteLine(Demo.staticReadOnlyVal);
            Console.ReadKey();
        }
    }

}

