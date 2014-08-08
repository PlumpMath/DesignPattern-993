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

        public abstract double GetResult();
        
    }

    /// <summary>
    /// 加法
    /// </summary>
    public class CalAdd : CalBase
    {
        public override double GetResult()
        {
            return NumberA + NumberB; 
        }
    }

    /// <summary>
    /// 减法
    /// </summary>
    public class CalSub : CalBase
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    /// <summary>
    /// 乘法
    /// </summary>
    public class CalMul : CalBase
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }

    /// <summary>
    /// 除法
    /// </summary>
    public class CalDiv : CalBase
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            return NumberA / NumberB;
        }
    }
}
