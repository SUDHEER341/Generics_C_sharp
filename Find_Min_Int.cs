using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Find_Min_Int
    {
        public static void Find_Minimum_Of_Three_Integers()
        {
            Console.WriteLine("Enter the first number");
            int number_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            int number_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number");
            int number_3 = Convert.ToInt32(Console.ReadLine());

            int minimum_Value = number_1;

            if (number_2.CompareTo(minimum_Value) < 0)
                minimum_Value = number_2;
            if (number_3.CompareTo(minimum_Value) < 0)
                minimum_Value = number_3;

            Console.WriteLine($"The minimum values is : {minimum_Value}");

        }
    }
}
