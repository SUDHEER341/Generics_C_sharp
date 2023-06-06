using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DeleteArray
    {
        private object[] array;

        public DeleteArray(object[] initialArray) 
        {
            array = initialArray;
        }

        public void Delete(object element)
        {
            int index = Array.IndexOf(array , element );

            if (index >= 0)
            {
                object[] newArray = new object[array.Length - 1];
                int newArrayIndex = 0;

                for(int i =0; i < array.Length; i++)
                {
                    if (!array[i].Equals(element))
                    {
                        newArray[newArrayIndex] = array[i];
                        newArrayIndex++;
                    }
                }

                array = newArray;
            }

            else
            {
                Console.WriteLine("Element not found in the array");
            }
        }

        public void DisplayArray()
        {
            Console.WriteLine("Array elements : ");
            
            foreach (var element in array)
            {
                Console.Write(" " +element);
            }
            Console.WriteLine();
        }

       

        }
    }
