
using Generics;
using System;

namespace Generics
{
    class Demo
    {
        public static void Main(String[] args)
        {

            object[] array = { 1, 2, 3, 4.2, 7, 'Z', 3.4, 'A' };

            DeleteArray deleteArray = new DeleteArray(array);

            deleteArray.DisplayArray();

            object elementToDelete = 4.2;

            deleteArray.Delete(elementToDelete);

            deleteArray.DisplayArray();

            Console.ReadLine();

            //===============Generic Method==================

            object[] array1 = { 1, 2.2, 'a', 3, 4.4, 'b', 'c' };

            DeleteArray1 deleteArray1 = new DeleteArray1();
            Console.WriteLine("Before delete the element :");
            Console.WriteLine("Array: " + string.Join(", ", array1));

            deleteArray1.DeleteElement(array1, 3);
            deleteArray1.DeleteElement(array1, 2.2);
            deleteArray1.DeleteElement(array1, 'c');

            Console.WriteLine("\nAfter delete the element :");
            Console.WriteLine("Array: " + string.Join(", ", array1));

            //============Generic Class========================

            object[] objArray = { 3, 4.2, 'g', 0, 8.5, 'm', "Azure" };

            Console.WriteLine("Before deletion:");
            Console.WriteLine("Object array: " + string.Join(", ", objArray));

            DeleteArray2<object> deleteObjArray = new DeleteArray2<object>(objArray);
            deleteObjArray.DeleteElementC(3);
            deleteObjArray.DeleteElementC('g');
            deleteObjArray.DeleteElementC(8.5);

            Console.WriteLine("\nAfter deletion:");
            Console.WriteLine("Object array: " + string.Join(", ", deleteObjArray.GetArray()));

            //===============Find Minimum=========================

            Find_Min_Int.Find_Minimum_Of_Three_Integers();
            Find_Min_Float.Find_Minimum_Of_Three_Floats();
            Find_Min_String.Find_Minimum_Of_Three_strings();

            //====================Find Minimum Refactor=====================

            MinimumValue<int> intMinimum = new MinimumValue<int>();
            int minInt = intMinimum.FindMinimum(2, 11);
            Console.WriteLine("Minimum Integer: " + minInt);

            MinimumValue<float> floatMinimum = new MinimumValue<float>();
            float minFloat = floatMinimum.FindMinimum(2.13f, 4.56f);
            Console.WriteLine("Minimum Float: " + minFloat);

            MinimumValue<string> stringMinimum = new MinimumValue<string>();
            string minstring= stringMinimum.FindMinimum("hello", "hii");
            Console.WriteLine("Minimum Float: " + minFloat);

        }
    }

                    
   
}


