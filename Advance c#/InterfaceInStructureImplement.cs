using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInStructureImplement
{
   
   
        interface MyBoook1     // Implement Interface
        {
            void add();       // Method
        }
        interface MyBook2
        {
            void add();
        }
    interface MyBook3
    { 
        void add(); 
    }

        struct Sample : MyBoook1, MyBook2, MyBook3   // Struct name of class
        {

        void MyBoook1.add()
        {
            Console.WriteLine("MyBook1.add() called");  

        }
        void MyBook2.add()
        {
            Console.WriteLine("MyBook2.add() called");

        }
        void MyBook3.add()
        {
            Console.WriteLine("MyBook3.add() called");
        }
            
        }
    class program
    {
        static void Main(string[] args)   //main
        {
            MyBoook1 add1;
            MyBook2 add2;
            MyBook3 add3;

            add1 = new Sample();    // object
            add2 = new Sample();
            add3 = new Sample();    
            add1.add(); 
            add2.add();
            add3.add(); 
            Console.ReadLine();  
        }

    }
  
    }


