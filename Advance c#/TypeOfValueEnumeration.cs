using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllowedIntergalTypes
{
    public class Program
    {
        enum Days : long
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Type underlinetype = Enum.GetUnderlyingType(typeof(Days));
            Console.WriteLine("Underlying type of days enum: {UnderlyingType}");
            Console.WriteLine("Days of the week:");
            foreach (var day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine($"{day}: {(long)day}");
                Console.ReadKey();
            }

        }
    }
}
