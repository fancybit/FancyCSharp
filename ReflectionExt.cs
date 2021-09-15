using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    public static class ReflectionExt
    {
        public static T GetProp<T>(this object self, string propName)
        {
            return (T)self.GetType().GetProperty(propName).GetValue(self);
        }

        public static void SetProp<T>(this object self, string propName, T value)
        {
            self.GetType().GetProperty(propName).SetValue(self, value);
        }

    }
}
