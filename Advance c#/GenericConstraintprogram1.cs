using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraintsProgram1
{
    public struct MyStruct<T> where T : struct
    {
        private T data;

        public MyStruct(T value)  // Constructor to initialize the data
        {
            this.data = value;
        }

        public T Data    
        {
            get { return this.Data; }   //property to get or set the data
            set { this.Data = value; }
        }

        public override string ToString()
        {
           return $"MyStruct<{typeof(T).Name}>: {data.ToString()}";
        }
    }
    
class Program
    {
        static void Main()
        {
            MyStruct<int> intStruct = new MyStruct<int>(42);
            Console.WriteLine(intStruct);

            MyStruct<float> floatStruct = new MyStruct<float>(3.14f);
            Console.WriteLine(floatStruct);
            Console.ReadKey();
        }
    }
    






}
