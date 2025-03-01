using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    public class CSSingleton<T>
    {
        public static T instance;

        public static T Inst
        {
            get
            {
                if (instance == null)
                {
                    instance = Activator.CreateInstance<T>();
                }
                return instance;
            }
        }
    }
}
