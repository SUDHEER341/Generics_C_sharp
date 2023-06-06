using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Find_Min_Float
    {
        public static void Find_Minimum_Of_Three_Floats()
        {
            Console.WriteLine("Enter the first number");
            float number_1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            float number_2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the Third number");
            float number_3 = Convert.ToSingle(Console.ReadLine());

            float minimum_Value = number_1;

            if (number_2.CompareTo(minimum_Value) < 0)
                minimum_Value = number_2;
            if (number_3.CompareTo(minimum_Value) < 0)
                minimum_Value = number_3;

            Console.WriteLine($"The minimum values is : {minimum_Value}");

        }
    }
}
