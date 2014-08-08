using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private const string TxtModel = "{0}\r\n\r\n{1}";

        private readonly StringBuilder _history = new StringBuilder();
        private readonly StringBuilder _input = new StringBuilder();
        private double _numberA;
        private double _numberB;
        private string _lastOper;
        private bool _isLastOper;
        private bool isFirstRun = true;

        private void numButton_Click(object sender, EventArgs e)
        {
            if (_isLastOper)
            {
                _input.Clear();
            }
            string text = GetButtonText(sender);
            _input.Append(text);
            if (_isLastOper)
            {
                _isLastOper = false;
                _numberB = ConvertDouble(_input.ToString());
                try
                {
                    _numberA = CalService.Cal(_lastOper, _numberA, _numberB);
                    label1.Text = string.Format(TxtModel, _history, _numberA);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("计算出错：" + ex.Message);
                }
                _history.Append(_lastOper).Append(_input);
                label1.Text = string.Format(TxtModel, _history, _numberA);
            }
            else
            {
                label1.Text = string.Format(TxtModel, _history, _input);
            }


        }


        private void calButton_Click(object sender, EventArgs e)
        {
            _isLastOper = true;
            string text = GetButtonText(sender);
            _lastOper = text;
            if (string.IsNullOrWhiteSpace(_input.ToString()))
            {
                _input.Append(0);
            }
            if (isFirstRun)
            {
                _numberA = ConvertDouble(_input.ToString());
                isFirstRun = false;
            }


            _history.Append(_input);
            label1.Text = string.Format(TxtModel, _history + text, _input);
        }

        private double ConvertDouble(string str)
        {
            double dou;
            if (!double.TryParse(str, out dou))
            {
                MessageBox.Show("输入的数字有问题");
            }
            return dou;
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private string GetButtonText(object sender)
        {
            Button btn = sender as Button;
            if (btn == null)
            {
                return string.Empty;
            }
            return btn.Text;
        }

    }
}
