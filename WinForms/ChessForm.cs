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
    public partial class ChessForm : Form
    {
        const string celSymbNames = "abcdefgh";

        ChessFigure[,] chessDesk = new ChessFigure[8, 8];

        public ChessForm()
        {
            InitializeComponent();
            for (int i = 0; i < celSymbNames.Length; i++)
            {
                var label = new Label();
                label.Text = "" + celSymbNames[i];
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                TLPChess.Controls.Add(label);
                TLPChess.SetCellPosition(label, new TableLayoutPanelCellPosition(i + 1, 0));
            }

            for (int i = 1; i < 9; i++)
            {
                var c = (9 - i).ToString();
                var label = new Label();
                label.Text = c;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                TLPChess.Controls.Add(label);
                TLPChess.SetCellPosition(label, new TableLayoutPanelCellPosition(0, i));
            }

            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    var panel = new Panel();
                    panel.Dock = DockStyle.Fill;
                    if ((i+j) % 2 != 0)
                    {
                        panel.BackColor = Color.White;
                    }
                    else 
                    {
                        panel.BackColor = Color.DimGray;
                    }
                    TLPChess.Controls.Add((Control)panel);
                    TLPChess.SetCellPosition((Control)panel, new TableLayoutPanelCellPosition(i, j));
                }
                //bool color;
                //if (i % 2 == 0)
                //{
                //    color = false;
                //}
                //else color = true;
                //for (int j = 1; j < 9; j++)
                //{
                //    var panel = new Panel();
                //    panel.Dock = DockStyle.Fill;
                //    if (color)
                //    {
                //        panel.BackColor = Color.White;
                //    }
                //    else
                //    {
                //        panel.BackColor = Color.DimGray;
                //    }
                //    color = !color;
                //    TLPChess.Controls.Add((Control)panel);
                //    TLPChess.SetCellPosition((Control)panel, new TableLayoutPanelCellPosition(i, j));
                //}
            }
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    var pb = new PictureBox();
                    pb.Dock = DockStyle.Fill;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.BackColor = (i + j) % 2 == 0 ? Color.White : Color.DimGray;
                    pb.Margin = new Padding(0);
                    //pb.Image = Image.FromStream(new MemoryStream(Properties.Resources.BishopBlack));
                    TLPChess.Controls.Add(pb);
                    TLPChess.SetCellPosition(pb, new TableLayoutPanelCellPosition(i, j));
                }

            }

        }

        void ResetDesk()
        {
            

            chessDesk[0, 0] = ChessFigure.Rock | ChessFigure.Black;
            chessDesk[0, 7] = ChessFigure.Rock | ChessFigure.Black;
            chessDesk[7, 0] = ChessFigure.Rock;
            chessDesk[7, 7] = ChessFigure.Rock;

        }

        void PaintCell(int i, int j)
        {
            //var figure = chessDesk[i, j];
            //switch(figure)
            //{
            //    case ChessFigure.Rock;
            //}
        }

        private void ChessForm_Resize(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null)
            {
                control.Size = new Size(control.Width, control.Width);
            }
            //var forms = sender as ChessForm;
            //if (forms != null)
            //{
            //    forms.Width = forms.Height;
            //}
        }
    }
}
