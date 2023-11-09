using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class MinimumeGap
    {
        private static int Find(int input)
        {
            int GreaterSquareRoot = (int)Math.Ceiling(Math.Sqrt(input));
            int LowerSquareRoot = (int)Math.Floor(Math.Sqrt(input));

            int GreaterPerfectSquare = GreaterSquareRoot * GreaterSquareRoot;
            int LowerPerfectSquare = LowerSquareRoot * LowerSquareRoot;

            int minimumGap = Math.Min(GreaterPerfectSquare - input, input - LowerPerfectSquare);

            return minimumGap;

        }
        public static void FindMinimumGap()
        {
            int input;
            Console.Write("Enter a Number : ");
            input = Convert.ToInt32(Console.ReadLine());

            int result = Find(input);

            Console.WriteLine("The minimum gap to make {0} a perfect square is {1}", input, result);
        }
    }
}
