using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    public static class StringExt
    {
        public static string Slice(this string self, int start, int end)
        {
            if (start < 0)
            {
                start = self.Length + start;
            }
            if (end < 0)
            {
                end = self.Length + end;
            }
            if (start > end)
            {
                (start, end) = (end, start);
            }
            return self.Substring(start, end - start + 1);
        }

        public static string SubStringEx(this string self, int start, int length)
        {
            if (start < 0)
            {
                start = self.Length + start;
            }
            return self.Substring(start, length);
        }
    }
}
