
namespace WinForms
{
    partial class CalendarDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btGetSelectDateTime = new System.Windows.Forms.Button();
            this.lbSelDateTime = new System.Windows.Forms.Label();
            this.btSetCurDate = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btGetDays = new System.Windows.Forms.Button();
            this.lbGetCalendarDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 27);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btGetSelectDateTime
            // 
            this.btGetSelectDateTime.Location = new System.Drawing.Point(32, 80);
            this.btGetSelectDateTime.Name = "btGetSelectDateTime";
            this.btGetSelectDateTime.Size = new System.Drawing.Size(175, 29);
            this.btGetSelectDateTime.TabIndex = 1;
            this.btGetSelectDateTime.Text = "Get selected date time";
            this.btGetSelectDateTime.UseVisualStyleBackColor = true;
            this.btGetSelectDateTime.Click += new System.EventHandler(this.btGetSelectDateTime_Click);
            // 
            // lbSelDateTime
            // 
            this.lbSelDateTime.Location = new System.Drawing.Point(228, 83);
            this.lbSelDateTime.Name = "lbSelDateTime";
            this.lbSelDateTime.Size = new System.Drawing.Size(150, 25);
            this.lbSelDateTime.TabIndex = 2;
            this.lbSelDateTime.Text = "Select Data Time";
            // 
            // btSetCurDate
            // 
            this.btSetCurDate.Location = new System.Drawing.Point(32, 130);
            this.btSetCurDate.Name = "btSetCurDate";
            this.btSetCurDate.Size = new System.Drawing.Size(175, 29);
            this.btSetCurDate.TabIndex = 3;
            this.btSetCurDate.Text = "Set current date";
            this.btSetCurDate.UseVisualStyleBackColor = true;
            this.btSetCurDate.Click += new System.EventHandler(this.btSetCurDate_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(32, 190);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // btGetDays
            // 
            this.btGetDays.Location = new System.Drawing.Point(316, 201);
            this.btGetDays.Name = "btGetDays";
            this.btGetDays.Size = new System.Drawing.Size(94, 29);
            this.btGetDays.TabIndex = 5;
            this.btGetDays.Text = "GetDays";
            this.btGetDays.UseVisualStyleBackColor = true;
            this.btGetDays.Click += new System.EventHandler(this.btGetDays_Click);
            // 
            // lbGetCalendarDays
            // 
            this.lbGetCalendarDays.AutoSize = true;
            this.lbGetCalendarDays.Location = new System.Drawing.Point(316, 253);
            this.lbGetCalendarDays.Name = "lbGetCalendarDays";
            this.lbGetCalendarDays.Size = new System.Drawing.Size(127, 20);
            this.lbGetCalendarDays.TabIndex = 6;
            this.lbGetCalendarDays.Text = "Get calendar days";
            // 
            // CalendarDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbGetCalendarDays);
            this.Controls.Add(this.btGetDays);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btSetCurDate);
            this.Controls.Add(this.lbSelDateTime);
            this.Controls.Add(this.btGetSelectDateTime);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "CalendarDemo";
            this.Text = "CalendarDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btGetSelectDateTime;
        private System.Windows.Forms.Label lbSelDateTime;
        private System.Windows.Forms.Button btSetCurDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btGetDays;
        private System.Windows.Forms.Label lbGetCalendarDays;
    }
}