
namespace DZ_1WPF
{
    partial class Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btDelLastSymb = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btPoint = new System.Windows.Forms.Button();
            this.btNull = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.70087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.29914F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 103);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(3, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(425, 60);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btCE, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btC, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btDelLastSymb, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btDivision, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btMult, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.bt4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.bt5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bt6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btMinus, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.bt1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.bt2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.bt3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btPlus, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(431, 316);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btCE
            // 
            this.btCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCE.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCE.Location = new System.Drawing.Point(3, 3);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(101, 73);
            this.btCE.TabIndex = 0;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btC
            // 
            this.btC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btC.Location = new System.Drawing.Point(110, 3);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(101, 73);
            this.btC.TabIndex = 1;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btDelLastSymb
            // 
            this.btDelLastSymb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDelLastSymb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDelLastSymb.Location = new System.Drawing.Point(217, 3);
            this.btDelLastSymb.Name = "btDelLastSymb";
            this.btDelLastSymb.Size = new System.Drawing.Size(101, 73);
            this.btDelLastSymb.TabIndex = 2;
            this.btDelLastSymb.Text = "<";
            this.btDelLastSymb.UseVisualStyleBackColor = true;
            this.btDelLastSymb.Click += new System.EventHandler(this.btDelLastSymb_Click);
            // 
            // btDivision
            // 
            this.btDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDivision.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDivision.Location = new System.Drawing.Point(324, 3);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(104, 73);
            this.btDivision.TabIndex = 3;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // bt7
            // 
            this.bt7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt7.Location = new System.Drawing.Point(3, 82);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(101, 73);
            this.bt7.TabIndex = 4;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt8.Location = new System.Drawing.Point(110, 82);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(101, 73);
            this.bt8.TabIndex = 5;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt9.Location = new System.Drawing.Point(217, 82);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(101, 73);
            this.bt9.TabIndex = 6;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btMult
            // 
            this.btMult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMult.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMult.Location = new System.Drawing.Point(324, 82);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(104, 73);
            this.btMult.TabIndex = 7;
            this.btMult.Text = "*";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // bt4
            // 
            this.bt4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt4.Location = new System.Drawing.Point(3, 161);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(101, 73);
            this.bt4.TabIndex = 8;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt5.Location = new System.Drawing.Point(110, 161);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(101, 73);
            this.bt5.TabIndex = 9;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt6.Location = new System.Drawing.Point(217, 161);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(101, 73);
            this.bt6.TabIndex = 10;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // btMinus
            // 
            this.btMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btMinus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMinus.Location = new System.Drawing.Point(324, 161);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(104, 73);
            this.btMinus.TabIndex = 11;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // bt1
            // 
            this.bt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt1.Location = new System.Drawing.Point(3, 240);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(101, 73);
            this.bt1.TabIndex = 12;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt2.Location = new System.Drawing.Point(110, 240);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(101, 73);
            this.bt2.TabIndex = 13;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt3.Location = new System.Drawing.Point(217, 240);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(101, 73);
            this.bt3.TabIndex = 14;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btPlus
            // 
            this.btPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPlus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPlus.Location = new System.Drawing.Point(324, 240);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(104, 73);
            this.btPlus.TabIndex = 15;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.8366F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.8366F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btPoint, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btNull, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btEquals, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 419);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(431, 66);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btPoint
            // 
            this.btPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPoint.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPoint.Location = new System.Drawing.Point(3, 3);
            this.btPoint.Name = "btPoint";
            this.btPoint.Size = new System.Drawing.Size(101, 60);
            this.btPoint.TabIndex = 0;
            this.btPoint.Text = ".";
            this.btPoint.UseVisualStyleBackColor = true;
            this.btPoint.Click += new System.EventHandler(this.btPoint_Click);
            // 
            // btNull
            // 
            this.btNull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNull.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btNull.Location = new System.Drawing.Point(110, 3);
            this.btNull.Name = "btNull";
            this.btNull.Size = new System.Drawing.Size(101, 60);
            this.btNull.TabIndex = 1;
            this.btNull.Text = "0";
            this.btNull.UseVisualStyleBackColor = true;
            this.btNull.Click += new System.EventHandler(this.btNull_Click);
            // 
            // btEquals
            // 
            this.btEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btEquals.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEquals.Location = new System.Drawing.Point(217, 3);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(211, 60);
            this.btEquals.TabIndex = 2;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 485);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calculator_FormClosed);
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btDelLastSymb;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btPoint;
        private System.Windows.Forms.Button btNull;
        private System.Windows.Forms.Button btEquals;
    }
}