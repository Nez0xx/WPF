using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(800, 450);
            MaximizeBox = false;
        }

        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            textBox1.Text = string.Format("X координата мыши, f={0}", e.X);
            textBox2.Text = string.Format("Y координата мыши, b={0}", e.Y);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double h = double.Parse(textBox7.Text);
                double d = double.Parse(textBox8.Text);
                double o1 = double.Parse(textBox9.Text);

                double f, b;
                f = (double)Cursor.Position.X;
                b = (double)Cursor.Position.Y;

                double q = Math.Sin((h + (d / Math.Exp(o1)))*(Math.PI/180)) - o1 + Math.Abs(Math.Sin(f*(Math.PI/180)) + Math.Sqrt(Math.Abs(Math.Sin(b*(Math.PI/180)))));
                Text = string.Format("Q={0}", q);
            }
            catch (Exception ex)
            {
               Text = "ERROR";
            }
        }
    }
}
