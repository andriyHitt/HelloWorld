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
    public partial class ControllsDemoForm : Form
    {
        public string MyLogin { get => tbLogin.Text; set => tbLogin.Text = value; }
        public string MyPassword { get => tbPassword.Text; }
        public ControllsDemoForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ControllsDemoForm_Load(object sender, EventArgs e)
        {

        }

        private void ControllsDemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
