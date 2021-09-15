using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCsharp
{
    public class MaxCounter
    {
        protected double number = double.MinValue;
        public void Add(double num)
        {
            if (num > number) number = num;
        }
        public void Reset()
        {
            number = double.MinValue;
        }
        public double Get()
        {
            return number;
        }
    }

    public class MinCounter
    {
        protected double number = double.MaxValue;
        public void Add(double num)
        {
            if (num < number) number = num;
        }
        public void Reset()
        {
            number = double.MaxValue;
        }
        public double Get()
        {
            return number;
        }
    }
}
