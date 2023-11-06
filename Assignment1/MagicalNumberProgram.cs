using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalNumberProgram
{
    public class Program
    {
        public static void CheckMagicalNumber()
        {
            string input;
            Console.WriteLine("Enter your Number");
            input = Console.ReadLine(); 
            StringBuilder sb = new StringBuilder(); 
            bool EndProcess = false;
            int sum = 0;
            while (!EndProcess)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    int num = sb[i] - '0';  
                    sum += num;
                    
                }
                if (sum >= 10)
                {
                    sb.Clear();
                    sb.Append(sum.ToString());
                    sum = 0;

                }
                else
                { 
                    EndProcess = true;  
                }
                if (sum == 1)
                    Console.Write("{0} is a magical Number : ", input);
                else
                    Console.WriteLine("{0} is not a Magical Number : ", input);
                     

            }
        }

        
        static void Main(string[] args)
        {
             
            CheckMagicalNumber();
            Console.ReadKey();
        }
    }
}
