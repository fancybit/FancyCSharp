using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    public class RegItem
    {
        public string Name;
        public Func<object> Creator;
        public ELifetime Lifetime;
    }

    public enum ELifetime
    {
        Singleton,
        Transient,
        Scoped
    }
}
