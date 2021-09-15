using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCsharp
{
    public partial class FancyLog
    {
        public static StringBuilder sb = new StringBuilder();
        public static void WriteLine(object text)
        {
            sb.Append(text.ToString());
            sb.Append("\n");
        }
        public static void Write(object text)
        {
            sb.Append(text.ToString());
        }
        public static void Clear()
        {
            sb.Clear();
        }
        public static void Save()
        {
            using (var fs = new FileStream("log.txt", FileMode.OpenOrCreate,FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine(sb.ToString());
            }
        }

    }
}
