using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Find_Min_String
    {
        public static void Find_Minimum_Of_Three_strings()
        {
            Console.WriteLine("Enter the first word ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter the Second word");
            string s2 = Console.ReadLine();

            Console.WriteLine("Enter the Third word");
            string s3 = Console.ReadLine();

            string minimum_Value = s1;

            if (s2.CompareTo(minimum_Value) < 0)
                minimum_Value = s2;
            if (s3.CompareTo(minimum_Value) < 0)
                minimum_Value = s3;

            Console.WriteLine($"The minimum values is : {minimum_Value}");

        }
    }
}
