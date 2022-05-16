using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;
using System.Drawing.Drawing2D;

namespace lr17
{
    public partial class Form1 : Form
    {
        private Point center;
        private float abscissaLength, ordinateLength;
        private float r1, r2;
        public Form1()
        {
            InitializeComponent();
       
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            center = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            ordinateLength = ClientSize.Height - (ClientSize.Height * (float)0.1);
            abscissaLength = ordinateLength;
            r1 = abscissaLength / 4;
            r2 = abscissaLength / 8;

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            Pen penBase = new Pen(Color.Black, 3);
            gr.DrawLine(penBase, center.X, center.Y - (ordinateLength / 2), center.X, center.Y + (ordinateLength / 2)); // ось ординат
            gr.DrawLine(penBase, center.X - (ordinateLength / 2), center.Y, center.X + (ordinateLength / 2), center.Y); // ось абсцисс
            gr.DrawString("2", new Font("Microsoft Sans Serif", 16), new SolidBrush(Color.Black), center.X + (abscissaLength / 4), center.Y); //отметка x=2 на оси абсцисс
            gr.DrawString("1", new Font("Microsoft Sans Serif", 16), new SolidBrush(Color.Black), center.X, center.Y - (ordinateLength / 8)); //отметка y=1 на оси ординат

            gr.DrawEllipse(new Pen(Color.Blue, 3), center.X - r1, center.Y - r1, 2 * r1, 2 * r1);
            gr.DrawEllipse(new Pen(Color.Red, 3), center.X - r2, center.Y - r2, 2 * r2, 2 * r2);
            gr.DrawEllipse(new Pen(Color.Red, 3), center.X, center.Y - r2, 2 * r2, 2 * r2);

            gr.DrawLine(new Pen(Color.Green, 3), center.X - (abscissaLength / 4), center.Y + (ordinateLength / 8),
                center.X + (abscissaLength/4), center.Y-(ordinateLength/8));
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
