using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(800, 450);
            MaximizeBox = false;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Screenshot_13.png");

            listBoxR.SelectedIndex = 0;
            listBoxN.SelectedIndex = 0;
            textBoxX.Text = "0";
            textBoxN.Text = "0";
            textBoxA.Text = "0";
            textBoxB.Text = "0";
        }

        public int Fact(int a)
        {
            if (a == 0) return 1;
            return a * Fact(a - 1);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double z = 0;
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double n = Convert.ToDouble(textBoxN.Text);
                double a = Convert.ToDouble(textBoxA.Text);
                double b = Convert.ToDouble(textBoxB.Text);
                int R = int.Parse(listBoxR.SelectedIndex.ToString());
                int N = int.Parse(listBoxN.SelectedIndex.ToString());

                if (radioButton1.Checked)
                {
                    for (int i=1; i <= n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            z += Math.Pow(x, i) / Fact(i+1);
                        }
                        else
                        {
                            z -= Math.Pow(x, i) / Fact(i+1);
                        }

                    }
                }
                else if (radioButton2.Checked)
                {
                    double rSum = 0;
                    for(int i=1; i <=N; i++)
                    {
                        for(int j=1; j <=R; j++)
                            rSum += (a * Math.Pow(i, 2)) / (Math.Pow(i, 3) + b * Math.Pow(j, 3));
                        z += rSum;
                    }
                }

                textBoxZ.Text = z.ToString();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
    }
}
