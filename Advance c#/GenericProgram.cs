using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProgram1
{
    class TestGenericClass<T> 
    {
        private T _variable;
        public T variable2 { get; set; }

        public TestGenericClass(T value)
        {
            _variable = value;
            variable2 = value;
        }

        public T TestMethod(T Param1)
        {
            Console.WriteLine("Parameter type: {0}, value {1}", typeof(T).ToString(), Param1);
            Console.WriteLine("Return type: {0}, value {1}", typeof(T).ToString(), _variable);
            return _variable;
        }
        
    }

    
    public class Program
    {
        static void Main(string[] args)
        {
            
            TestGenericClass<int> obj = new TestGenericClass<int>(123);
            Console.WriteLine(obj.variable2);
            Console.ReadKey();
        }
    }
}
