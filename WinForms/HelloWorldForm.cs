using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class HelloWorldForm : Form
    {
        private bool _directionRight = true;
        private int _step = 5;
        public HelloWorldForm()
        {
            InitializeComponent();

            //var width = ClientSize.Width;
            //var heigth = ClientSize.Height;
            //var locate = Location.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var size = ClientSize;
            if (_directionRight)
            {
                var newPositionX = Skip.Location.X + _step;
                if ((newPositionX + Skip.Size.Width) <= ClientSize.Width)
                {
                    Skip.Location = new Point(newPositionX, Skip.Location.Y);
                }
                else
                {
                    _directionRight = false;
                }
                //var x = Skip.Size.Width + Skip.Location.X;
            }
            else
            {
                var newPositionX = Skip.Location.X - _step;
                if (newPositionX >= 0)
                {
                    Skip.Location = new Point(newPositionX, Skip.Location.Y);
                }
                else
                {
                    _directionRight = true;
                }
            }
        }

        private void HelloWorldForm_Load(object sender, EventArgs e)
        {
            Skip.Location = new Point(0, 0);
            timer1.Enabled = true;
        }

        private void Time_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            //Time.Text = 
            //DialogResult = DialogResult.OK;
            //Close();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
        }
    }
}
