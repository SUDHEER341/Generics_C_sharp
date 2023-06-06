using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class DeleteArray2<T>
    {
        private T[] array;

        public DeleteArray2(T[] array)
        {
            this.array = array;
        }

        public void DeleteElementC(T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    Array.Resize(ref array, array.Length - 1);
                    break;
                }
            }
        }

        public T[] GetArray()
        {
            return array;
        }
    }
}
