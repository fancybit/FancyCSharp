using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    public static class LinqExt
    {
        /*public static T GetOrCreate<T>(this DbSet<T> self, Func<T, bool> condition) where T : class
        {
            var x = self.FirstOrDefault(condition);
            if (x == null)
            {
                x = default(T);
                self.Add(x);
            }
            return x;
        }*/

        public static T MaxOne<T>(this ICollection<T> self, Func<T, float> ValueGettor) where T : class
        {
            var max = float.MinValue;
            T obj = null;
            foreach (var item in self)
            {
                var x = ValueGettor(item);
                if (x > max)
                {
                    max = x;
                    obj = item;
                }
            }
            return obj;
        }

        public static T MinOne<T>(this ICollection<T> self, Func<T, float> ValueGettor) where T : class
        {
            var min = float.MaxValue;
            T obj = null;
            foreach (var item in self)
            {
                var x = ValueGettor(item);
                if (x < min)
                {
                    min = x;
                    obj = item;
                }
            }
            return obj;
        }
    }
}
