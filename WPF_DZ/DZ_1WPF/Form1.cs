using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1WPF
{
    public partial class Buttons : Form
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void Buttons_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buttons_Load_1(object sender, EventArgs e)
        {

        }

        private void Buttons_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btNavy_Click(object sender, EventArgs e)
        {

        }

        private void btCalculator_Click(object sender, EventArgs e)
        {
            var calculator = new Calculator();
            calculator.Show();
        }
    }
}
