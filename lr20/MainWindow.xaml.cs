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
using System.Drawing;
using System.Timers;

namespace lr20
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

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            sldSrc.Value = 24;
        }

        private void btnLarge_Click(object sender, RoutedEventArgs e)
        {
            sldSrc.Value = 45;
        }

        private void randomColor_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            Color rndColor = Color.FromArgb((byte)rng.Next(256), (byte)rng.Next(256), (byte)rng.Next(256), (byte)rng.Next(256));
            SolidColorBrush brush = new SolidColorBrush(rndColor);

            txtTarget.Foreground = brush;
        }

        private void randomFont_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            string[] fonts =
            {
                "Verdana",
                "Comic Sans MS",
                "Times New Roman",
                "Arial",
                "Microsoft Sans Serif"
            };

            txtTarget.FontFamily = new FontFamily(fonts[rng.Next(0, fonts.Length)]);
        }
    }
}
