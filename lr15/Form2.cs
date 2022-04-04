using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txtBoxN.Text);
                double x = Convert.ToDouble(txtBoxX.Text);

                double u;
                if (n == 0)
                    u = 0;
                else if (n < 0)
                    throw new Exception("Введенные значения некорректны.");
                else
                {
                    u = 1;
                    for (int i = 0; i < n - 1; i++)
                        if (i % 2 == 0)
                            u -= Math.Pow(Math.Sin(x * (Math.PI / 180)), i + 2) / (i + 2);
                        else
                            u += Math.Pow(Math.Sin(x * (Math.PI / 180)), i + 2) / (i + 2);
                }
                textBoxRes.Text = u.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
