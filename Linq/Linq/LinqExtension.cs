using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Count
{
    public static  class LinqExtension
    {
        public static int Count<T>(this IEnumerable<T> Sequence)
        {
            int count = 0;
            foreach (var item in Sequence)
            {
                count += 1;
            }
            return count;
        }
    }
}
