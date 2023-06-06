using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MinimumValue<T> where T : IComparable<T>
    {
        public T FindMinimum(T a, T b)
        {
            return a.CompareTo(b) < 0 ? a : b;
        }
    }
}
