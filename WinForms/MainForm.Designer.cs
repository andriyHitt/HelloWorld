
namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.btChessForm = new System.Windows.Forms.Button();
            this.bCalendar = new System.Windows.Forms.Button();
            this.btListBox = new System.Windows.Forms.Button();
            this.btTrreView = new System.Windows.Forms.Button();
            this.btOpenFileDialog = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show Dialog Hello World";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Show Hello World";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(177, 168);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(94, 29);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            this.btLogin.MouseEnter += new System.EventHandler(this.btLogin_MouseEnter);
            this.btLogin.MouseLeave += new System.EventHandler(this.btLogin_MouseLeave);
            // 
            // btChessForm
            // 
            this.btChessForm.Location = new System.Drawing.Point(601, 203);
            this.btChessForm.Name = "btChessForm";
            this.btChessForm.Size = new System.Drawing.Size(94, 29);
            this.btChessForm.TabIndex = 5;
            this.btChessForm.Text = "Chess";
            this.btChessForm.UseVisualStyleBackColor = true;
            this.btChessForm.Click += new System.EventHandler(this.btChessForm_Click);
            // 
            // bCalendar
            // 
            this.bCalendar.Location = new System.Drawing.Point(315, 151);
            this.bCalendar.Name = "bCalendar";
            this.bCalendar.Size = new System.Drawing.Size(94, 29);
            this.bCalendar.TabIndex = 6;
            this.bCalendar.Text = "Calendar";
            this.bCalendar.UseVisualStyleBackColor = true;
            this.bCalendar.Click += new System.EventHandler(this.bCalendar_Click);
            // 
            // btListBox
            // 
            this.btListBox.Location = new System.Drawing.Point(315, 186);
            this.btListBox.Name = "btListBox";
            this.btListBox.Size = new System.Drawing.Size(94, 29);
            this.btListBox.TabIndex = 7;
            this.btListBox.Text = "ListBox";
            this.btListBox.UseVisualStyleBackColor = true;
            this.btListBox.Click += new System.EventHandler(this.btListBox_Click);
            // 
            // btTrreView
            // 
            this.btTrreView.Location = new System.Drawing.Point(315, 221);
            this.btTrreView.Name = "btTrreView";
            this.btTrreView.Size = new System.Drawing.Size(94, 29);
            this.btTrreView.TabIndex = 8;
            this.btTrreView.Text = "Tree view";
            this.btTrreView.UseVisualStyleBackColor = true;
            this.btTrreView.Click += new System.EventHandler(this.btTrreView_Click);
            // 
            // btOpenFileDialog
            // 
            this.btOpenFileDialog.Location = new System.Drawing.Point(25, 255);
            this.btOpenFileDialog.Name = "btOpenFileDialog";
            this.btOpenFileDialog.Size = new System.Drawing.Size(94, 29);
            this.btOpenFileDialog.TabIndex = 9;
            this.btOpenFileDialog.Text = "Open File";
            this.btOpenFileDialog.UseVisualStyleBackColor = true;
            this.btOpenFileDialog.Click += new System.EventHandler(this.btOpenFileDialog_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.demoToolStripMenuItem,
            this.chessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // demoToolStripMenuItem
            // 
            this.demoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarDemoToolStripMenuItem,
            this.listDemoToolStripMenuItem,
            this.treeViewDemoToolStripMenuItem});
            this.demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            this.demoToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.demoToolStripMenuItem.Text = "Demo";
            // 
            // calendarDemoToolStripMenuItem
            // 
            this.calendarDemoToolStripMenuItem.Name = "calendarDemoToolStripMenuItem";
            this.calendarDemoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calendarDemoToolStripMenuItem.Text = "Calendar Demo";
            this.calendarDemoToolStripMenuItem.Click += new System.EventHandler(this.calendarDemoToolStripMenuItem_Click);
            // 
            // listDemoToolStripMenuItem
            // 
            this.listDemoToolStripMenuItem.Name = "listDemoToolStripMenuItem";
            this.listDemoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listDemoToolStripMenuItem.Text = "List Demo";
            this.listDemoToolStripMenuItem.Click += new System.EventHandler(this.listDemoToolStripMenuItem_Click);
            // 
            // treeViewDemoToolStripMenuItem
            // 
            this.treeViewDemoToolStripMenuItem.Name = "treeViewDemoToolStripMenuItem";
            this.treeViewDemoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.treeViewDemoToolStripMenuItem.Text = "Tree View Demo";
            this.treeViewDemoToolStripMenuItem.Click += new System.EventHandler(this.treeViewDemoToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            // 
            // chessToolStripMenuItem
            // 
            this.chessToolStripMenuItem.Name = "chessToolStripMenuItem";
            this.chessToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.chessToolStripMenuItem.Text = "Chess";
            this.chessToolStripMenuItem.Click += new System.EventHandler(this.chessToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSaveMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 28);
            // 
            // toolSaveMenuItem
            // 
            this.toolSaveMenuItem.Name = "toolSaveMenuItem";
            this.toolSaveMenuItem.Size = new System.Drawing.Size(109, 24);
            this.toolSaveMenuItem.Text = "Save";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuCollapse,
            this.toolStripExpand});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(211, 80);
            // 
            // toolStripMenuCollapse
            // 
            this.toolStripMenuCollapse.Name = "toolStripMenuCollapse";
            this.toolStripMenuCollapse.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuCollapse.Text = "Collapse";
            this.toolStripMenuCollapse.Click += new System.EventHandler(this.toolStripMenuCollapse_Click);
            // 
            // toolStripExpand
            // 
            this.toolStripExpand.Name = "toolStripExpand";
            this.toolStripExpand.Size = new System.Drawing.Size(210, 24);
            this.toolStripExpand.Text = "Expand";
            this.toolStripExpand.Click += new System.EventHandler(this.toolStripExpand_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.btOpenFileDialog);
            this.Controls.Add(this.btTrreView);
            this.Controls.Add(this.btListBox);
            this.Controls.Add(this.bCalendar);
            this.Controls.Add(this.btChessForm);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Hello World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btChessForm;
        private System.Windows.Forms.Button bCalendar;
        private System.Windows.Forms.Button btListBox;
        private System.Windows.Forms.Button btTrreView;
        private System.Windows.Forms.Button btOpenFileDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeViewDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chessToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuCollapse;
        private System.Windows.Forms.ToolStripMenuItem toolStripExpand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolSaveMenuItem;
    }
}

