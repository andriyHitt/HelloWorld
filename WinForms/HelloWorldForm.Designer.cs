
namespace WinForms
{
    partial class HelloWorldForm
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
            this.components = new System.ComponentModel.Container();
            this.Skip = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Skip
            // 
            this.Skip.Location = new System.Drawing.Point(544, 136);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(94, 29);
            this.Skip.TabIndex = 0;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.button1_Click);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(289, 365);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(225, 29);
            this.Time.TabIndex = 1;
            this.Time.Text = "button1";
            this.Time.UseVisualStyleBackColor = true;
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Skip);
            this.Name = "HelloWorldForm";
            this.Text = "HelloWorldForm";
            this.Load += new System.EventHandler(this.HelloWorldForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Time;
        private System.Windows.Forms.Timer timer2;
    }
}