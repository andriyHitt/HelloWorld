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
    public partial class CalendarDemo : Form
    {
        public CalendarDemo()
        {
            InitializeComponent();
        }

        private void btGetSelectDateTime_Click(object sender, EventArgs e)
        {
            lbSelDateTime.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btSetCurDate_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btGetDays_Click(object sender, EventArgs e)
        {
            lbGetCalendarDays.Text = monthCalendar1.SelectionRange.ToString();
        }
    }
}
