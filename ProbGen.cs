using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    /// <summary>
    /// 概率生成器
    /// </summary>
    public class ProbaGen<T>
    {
        protected List<ProbaItem> items = new List<ProbaItem>();
        protected Random rand = new Random();
        public void AddItem(T obj, float proba)
        {
            items.Add(new ProbaItem(obj,proba));
        }

        public T Gen()
        {
            var sum = items.Select(item => item.Probability).Sum();
            var x = rand.NextDouble() * sum;
            var cur = 0f;
            for(var i=0;i<items.Count;++i)
            {
                cur += items[i].Probability;
                if (x < cur)
                {
                    return items[i].Obj;
                }
            }
            return items.Last().Obj;
        }

        public class ProbaItem
        {
            public ProbaItem(T obj,float proba)
            {
                Obj = obj;
                Probability = proba;
            }
            public T Obj;
            public float Probability;
        }
    }
}
