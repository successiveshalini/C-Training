using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class RemoveSpace
    {
        public static void RemoveSpacesFromString(string input)
        {
            StringBuilder sb = new StringBuilder();
            bool isSpace = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (!isSpace)
                    {
                        sb.Append(' ');
                        isSpace = true;
                    }

                }
                else
                {
                    sb.Append(input[i]);
                    isSpace = true;

                }
            }
            Console.WriteLine("Resultant String: {0}", sb.ToString().Trim());
 

        }
        public static void RemoveSpaces()
        {
            Console.WriteLine("Enter your string: ");
            string input = Console.ReadLine();
            RemoveSpacesFromString(input);
        }
    }
}
