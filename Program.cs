﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.Write("Enter the Nth Number : ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("\nSum of N Numbers : " + sum);
            Console.ReadLine();
        }
    }
}
