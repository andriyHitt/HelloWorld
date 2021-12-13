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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Hello World","Привіт світ",MessageBoxButtons.OKCancel);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(this, "Ви дійсно хочете завершити роботу ?", "Hello World", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                e.Cancel = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var helloWorldForm = new HelloWorldForm();
            var dr = helloWorldForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var helloWorldForm = new HelloWorldForm();
            helloWorldForm.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            var controlForm = new ControllsDemoForm();
            controlForm.MyLogin = "Petro";
            var result = controlForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var login = controlForm.MyLogin;
                var password = controlForm.MyPassword;
                MessageBox.Show($"{login} with password {password}");
            }
        }

        private Color oldColor;

        private void btLogin_MouseEnter(object sender, EventArgs e)
        {
            oldColor = btLogin.BackColor;
            btLogin.BackColor = Color.Red;
        }

        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            btLogin.BackColor = oldColor;
        }

        private void btChessForm_Click(object sender, EventArgs e)
        {
            var chessForm = new ChessForm();
            chessForm.Show();
        }

        private void bCalendar_Click(object sender, EventArgs e)
        {
            var calendarForm = new CalendarDemo();
            calendarForm.Show();
        }

        private void btListBox_Click(object sender, EventArgs e)
        {
            var listDemoForm = new List_DemoForm();
            listDemoForm.Show();
        }

        private void btTrreView_Click(object sender, EventArgs e)
        {
            var treeView = new ExplorerForm();
            treeView.Show();
        }

        private void btOpenFileDialog_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            fontDialog.ShowDialog();

            
            
            var opColorDial = new ColorDialog();
            opColorDial.ShowDialog();
            

            
            //var sfd = new SaveFileDialog();
            var opnFolder = new FolderBrowserDialog();
            opnFolder.ShowDialog();
            
            
            var of = new OpenFileDialog();
            of.Multiselect = true;
            var dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (of.FileNames.Length > 0)
                {

                }
            }
        }

        private void calendarDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calendarForm = new CalendarDemo();
            calendarForm.Show();

        }

        private void listDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listDemoForm = new List_DemoForm();
            listDemoForm.Show();

        }

        private void treeViewDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var treeView = new ExplorerForm();
            treeView.Show();

        }

        private void chessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chessForm = new ChessForm();
            chessForm.Show();

        }

        private void toolStripExpand_Click(object sender, EventArgs e)
        {
            //MainForm.ActiveForm.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuCollapse_Click(object sender, EventArgs e)
        {
            //MainForm.ActiveForm.WindowState = FormWindowState.Minimized;
        }
    }
}
