using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleFactory
{
    public class CalService
    {
        public static double Cal(string oper, double numberA, double numberB)
        {
            CalBase cal = CalFactory.GetCal(oper);
            if (cal == null)
            {
                MessageBox.Show("输入的运算符有问题");
                return 0;
            }
            cal.NumberA = numberA;
            cal.NumberB = numberB;
            try
            {
                return cal.GetResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show("计算出错：" + ex.Message);
                return 0;
            }
        }


    }
}
