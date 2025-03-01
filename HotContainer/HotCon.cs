using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    public class HotCon : CSSingleton<HotCon>
    {
        protected Dictionary<Type, Dictionary<string, RegItem>> ItemTable
            = new Dictionary<Type, Dictionary<string, RegItem>>();

        public HotCon() { }

        public void Register<TA, TI>(
            string name = "default",
            ELifetime lifetime = ELifetime.Singleton,
            Func<object> creator = null)
        {
            if (!typeof(TA).IsAssignableFrom(typeof(TI)))
                throw new Exception($"{typeof(TI).Name} is not Assignable From {typeof(TA).Name}");
            if (!ItemTable.TryGetValue(typeof(TA), out var items))
                ItemTable.Add(typeof(TA), items = new Dictionary<string, RegItem>());
            items[name] = new RegItem()
            {
                Name = name,
                Lifetime = lifetime,
                Creator = creator ?? (() => Activator.CreateInstance(typeof(TI)))
            };
        }

        public T Resolve<T>(string name = "default") where T : class
        {
            if (!ItemTable.TryGetValue(typeof(T), out var items))
                throw new Exception($"No Type Registerd of {typeof(T).Name}");
            if (!items.TryGetValue(name, out var item))
                throw new Exception($"No Name Registerd of {name} in {typeof(T).Name}");
            switch (item.Lifetime)
            {
                case ELifetime.Singleton:
                    return item.Creator() as T;
            }
            return null;
        }
    }
}
