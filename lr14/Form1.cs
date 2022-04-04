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
        public Form1()
        {
            InitializeComponent();
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
    }
}
