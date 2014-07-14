using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public abstract class CalBase
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        protected abstract double GetResult();
    }


    public class CalAdd : CalBase
    {
        protected override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
