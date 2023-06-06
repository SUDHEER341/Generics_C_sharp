using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class DeleteArray1
    {
        public void DeleteElement<T>(T[] array1, T element)
        {
            int elementIndex = Array.IndexOf(array1, element);
            if (elementIndex != -1)
            {
                for (int i = elementIndex; i < array1.Length - 1; i++)
                {
                    array1[i] = array1[i + 1];
                }
                Array.Resize(ref array1, array1.Length - 1);
            }
        }
    }
}
