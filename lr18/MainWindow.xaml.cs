using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lr18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(tbX.Text);
                double y = Convert.ToDouble(tbY.Text);
                int k = Convert.ToInt32(cbK.Text);
                int n = Convert.ToInt32(cbN.Text);

                double z = 0, tempSum = 0;
                for (int i = 1; i <= k; i++)
                {
                    z += tempSum;
                    for (int j = 1; j <= n; j++)
                        tempSum += (i * Math.Pow(x, i) + j * Math.Pow(y, j) / (i * j));
                }
                this.Title = string.Format("Z={0}", z);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", ex.Message);
            }
        }
    }
}
