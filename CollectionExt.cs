using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    public static class CollectionExt
    {
        static Random rnd = new Random();

        public static void Shuffle<T>(this IList<T> self)
        {
            //随机交换
            var rnd = new Random();
            int currentIndex;
            T tempValue;
            for (int i = self.Count - 1; i >= 0; i--)
            {
                currentIndex = (int)(rnd.NextDouble() * (i + 1));
                tempValue = self[currentIndex];
                self[currentIndex] = self[i];
                self[i] = tempValue;
            }
        }

        public static (T, int) RandPick<T>(this IList<T> self)
        {
            var index = (int)(rnd.NextDouble() * self.Count);
            return (self[index], index);
        }

        public static string JoinToStr<T>(this IEnumerable<T> self, string delimer)
        {
            var sb = new StringBuilder();
            foreach (var e in self)
            {
                sb.Append(e.ToString());
                sb.Append(delimer);
            }
            if (sb.Length > 0) sb.Remove(sb.Length - delimer.Length, delimer.Length);
            return sb.ToString();
        }

        public static int RemoveAll<T>(this IList<T> self, Func<T, bool> predict)
        {
            int count = 0;
            for (var i = 0; i < self.Count; ++i)
            {
                if (predict(self[i]))
                {
                    self.RemoveAt(i);
                    --i;
                    ++count;
                }
            }
            return count;
        }

        public static int RemoveSome<T>(this IList<T> self, Func<T, bool> predict, int num)
        {
            int count = 0;
            for (var i = 0; i < self.Count; ++i)
            {
                if (predict(self[i]))
                {
                    self.RemoveAt(i);
                    --i;
                    ++count;
                    if (count >= num) return count;
                }
            }
            return count;
        }
    }
}