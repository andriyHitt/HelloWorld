using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1WPF
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private double _left;
        private double _right;
        private double _result;
        private char _mathOperation;

        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

        private void bt1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "1";
            textBox1.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "2";
            textBox1.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "3";
            textBox1.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "4";
            textBox1.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "5";
            textBox1.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "6";
            textBox1.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "7";
            textBox1.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "8";
            textBox1.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox2.Text.First() == '0')
            {
                textBox2.Text = textBox2.Text.Remove(0);

                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
            }
            textBox2.Text += "9";
            textBox1.Text += "9";
        }

        private void btNull_Click(object sender, EventArgs e)
        {
            {
                textBox2.Text += "0";
                textBox1.Text += "0";
            }
        }

        private void btPoint_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = "0.";
                textBox1.Text += "0.";
            }
            else
            {
                if (!textBox2.Text.Contains('.'))
                {
                    textBox2.Text += ".";
                    textBox1.Text += ".";
                }
            }
        }

        private void btDelLastSymb_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Remove(0);
        }

        private void btC_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(0);
            if (textBox2.Text.Length != 0)
            {
                textBox2.Text = textBox2.Text.Remove(0);
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith(_mathOperation))
            {
                textBox1.Text += "+";
            }
            else
            {
                textBox1.Text = textBox1.Text.TrimEnd(_mathOperation);
                textBox1.Text += "+";
            }
            _mathOperation = '+';
            if (textBox2.Text.Length != 0)
            {
                _left = double.Parse(textBox2.Text, formatter);
                textBox2.Text = textBox2.Text.Remove(0);
            }
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith(_mathOperation))
            {
                textBox1.Text += "-";
            }
            else
            {
                textBox1.Text = textBox1.Text.TrimEnd(_mathOperation);
                textBox1.Text += "-";
            }

            _mathOperation = '-';
            if (textBox2.Text.Length != 0)
            {
                _left = double.Parse(textBox2.Text, formatter);
                textBox2.Text = textBox2.Text.Remove(0);
            }
        }
        private void btMult_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith(_mathOperation))
            {
                textBox1.Text += "*";
            }
            else
            {
                textBox1.Text = textBox1.Text.TrimEnd(_mathOperation);
                textBox1.Text += "*";
            }

            _mathOperation = '*';
            if (textBox2.Text.Length != 0)
            {
                _left = double.Parse(textBox2.Text, formatter);
                textBox2.Text = textBox2.Text.Remove(0);
            }
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith(_mathOperation))
            {
                textBox1.Text += "/";
            }
            else
            {
                textBox1.Text = textBox1.Text.TrimEnd(_mathOperation);
                textBox1.Text += "/";
            }

            _mathOperation = '/';
            if (textBox2.Text.Length != 0)
            {
                _left = double.Parse(textBox2.Text, formatter);
                textBox2.Text = textBox2.Text.Remove(0);
            }
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            _right = double.Parse(textBox2.Text, formatter);
            switch (_mathOperation)
            {
                case '+':
                    _result = _left + _right;
                    break;
                case '-':
                    _result = _left - _right;
                    break;
                case '*':
                    _result = _left * _right;
                    break;
                case '/':
                    _result = _left / _right;
                    break;
                default:
                    break;
            }
            textBox2.Text = Convert.ToString(_result);
        }

    }
}
