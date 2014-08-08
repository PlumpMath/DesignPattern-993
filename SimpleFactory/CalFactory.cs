using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class CalFactory
    {
        public static CalBase GetCal(string oper)
        {
            switch (oper)
            {
                case "+":
                    return new CalAdd();
                case "=":
                    return new CalSub();
                case "*":
                    return new CalMul();
                case "/":
                    return new CalDiv();
                default:
                    return null;
            }
        }
    }
}
