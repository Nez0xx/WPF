using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr14
{
    public partial class Form1 : Form
    {
        public enum DateTimeFormat
        {
            ShowTime,
            ShowDate
        }

        DateTimeFormat dtFormat = DateTimeFormat.ShowTime;
        ToolStripMenuItem currentCheckedItem;
        ToolStripMenuItem currentCheckedItemTask2;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Screenshot_14.png");
            Text = "Лабораторная работа №14. Пример строки состояния";
            CenterToScreen();
            BackColor = Color.CadetBlue;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;

            currentCheckedItemTask2 = toolStripMenuItemXY;
            currentCheckedItemTask2.Checked = true;
        }

        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToLongTimeString();
            else
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }

        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            contextMenuComboBox2.SelectedIndex = 0;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "белый": ; BackColor = Color.White; break;
                case "красный":; BackColor = Color.Red; break;
                case "черный":; BackColor = Color.Black; break;
                case "синий":; BackColor = Color.Blue; break;
                case "желтый":; BackColor = Color.Yellow; break;

                default: BackColor = SystemColors.Control; break;
            }
            switch (contextMenuComboBox2.Text)
            {
                case "белый":; BackColor = Color.White; break;
                case "красный":; BackColor = Color.Red; break;
                case "черный":; BackColor = Color.Black; break;
                case "синий":; BackColor = Color.Blue; break;
                case "желтый":; BackColor = Color.Yellow; break;

                default: BackColor = SystemColors.Control; break;
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == toolStripTextBox1 || sender == toolStripTextBox2 || sender == toolStripTextBox3)
                {
                    BackColor = Color.FromArgb(
                        Convert.ToInt32(toolStripTextBox1.Text),
                        Convert.ToInt32(toolStripTextBox2.Text),
                        Convert.ToInt32(toolStripTextBox3.Text));
                }
                else if (sender == contextMenuTextBox1 || sender == contextMenuTextBox2 || sender == contextMenuTextBox3)
                {
                    BackColor = Color.FromArgb(
                        Convert.ToInt32(contextMenuTextBox1.Text),
                        Convert.ToInt32(contextMenuTextBox2.Text),
                        Convert.ToInt32(contextMenuTextBox3.Text));
                }
            }
            catch
            {
                MessageBox.Show("необходимо ввести целое число от 0 до 255", "Ошибка в задании цвета");
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentCheckedItemTask2 == toolStripMenuItemXY)
                toolStripStatusLabelState.Text = string.Format("Координаты курсора равны (х, у): ({0}, {1})", e.X, e.Y);
            else
            {
                try { 
                    double z = (e.X + e.Y) / Math.Abs(e.Y - e.X);
                    toolStripStatusLabelState.Text = string.Format("z= {0}", z);
                }
                catch {
                    toolStripStatusLabelState.Text = "Курсор за пределами рабочей области";
                }
            }
        }

        private void toolStripMenuItemCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double x=0, y=0, z=0, a=0, b = 0;

                if (sender == toolStripMenuItemCalc) 
                {
                    x = Convert.ToDouble(toolStripTextBoxX.Text);
                    y = Convert.ToDouble(toolStripTextBoxY.Text);
                    z = Convert.ToDouble(toolStripTextBoxZ.Text);
                    a = Convert.ToDouble(toolStripComboBoxA.SelectedIndex);
                    b = Convert.ToDouble(toolStripComboBoxB.SelectedIndex);
                }
                else if (sender == toolStripMenuItemCM_Calc)
                {
                    x = Convert.ToDouble(toolStripTextBoxCM_X.Text);
                    y = Convert.ToDouble(toolStripTextBoxCM_Y.Text);
                    z = Convert.ToDouble(toolStripTextBoxCM_Z.Text);
                    a = Convert.ToDouble(toolStripComboBoxCM_A.SelectedIndex);
                    b = Convert.ToDouble(toolStripComboBoxCM_B.SelectedIndex);
                }

                double res;
                res = a * x / (b - y) + (b * y + Math.Sin(z*(Math.PI/180)) / (a * x));
                Text = string.Format("Результат выражения: {0}", res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void toolStripMenuItemZ_Click(object sender, EventArgs e)
        {
            currentCheckedItemTask2.Checked = false;
            currentCheckedItemTask2 = toolStripMenuItemZ;
            currentCheckedItemTask2.Checked = true;
        }

        private void toolStripMenuItemXY_Click(object sender, EventArgs e)
        {
            currentCheckedItemTask2.Checked = false;
            currentCheckedItemTask2 = toolStripMenuItemXY;
            currentCheckedItemTask2.Checked = true;
        }
    }
}
