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
    public partial class List_DemoForm : Form
    {
        public List_DemoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilderSelect = new StringBuilder();
            foreach(var items in checkedListBox1.SelectedItems)
            {
                stringBuilderSelect.Append(items.ToString());
                stringBuilderSelect.Append(";\n");
            }
            lbSelectItem.Text = stringBuilderSelect.ToString();

            
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var item in checkedListBox1.CheckedItems)
            {
                stringBuilder.Append(item.ToString());
                stringBuilder.Append(";\n");
            }
            lbGetItem.Text = stringBuilder.ToString();

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            lbSelectITEMS.Text = comboBox1.SelectedItem.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
