﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegatePrograms1
{
    delegate void dele(int a, int b);
    public class Oper
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
    }
    public class program
    {
        static void Main()
        {
            dele del = new dele(Oper.Add);
            del += new dele(Oper.Sub);
            del(4, 2);
            del -= new dele(Oper.Sub);
            del(1, 9);
            Console.Read();
        }
    }

}


