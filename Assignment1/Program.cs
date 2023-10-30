using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveMultipleSpace1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();
            str = str.Trim(); 
            string ans = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    continue;
                }
                else
                {
                    ans += str[i];
                }
            }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
        
    }
}
