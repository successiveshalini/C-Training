using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalNumber
{
    public class Program
    {
        public static void FindMagicalNumber(int num)
        {
            int result = num;
            int sum = 0;
            while (result > 0)
            {
                int x = num % 10;
                sum += x;
                num = num / 10;
                if (num == 0 && sum>8)
                {
                    num = sum;
                    sum = 0;

                }
                if (sum == 1)
                {
                    Console.WriteLine("{0} is a magical number:", result);

                }
                else
                {
                    Console.WriteLine("{0} is not magical number:", result);


                }
            }

        }
        public static void checkmagicalnumber()
        {
            string input;
            Console.WriteLine("Enter Your Number: ");
            input = Console.ReadLine();
            int num;
            if (int.TryParse(input, out num))
            {
                FindMagicalNumber(num);
            }
            else
            {
                Console.WriteLine("Wrong Input!!!");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("checkmagicalnumber");
            Console.ReadKey();  
        }
    }
}

