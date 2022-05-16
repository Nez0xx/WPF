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

namespace lr19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentHeight, currentWidth;
        public MainWindow()
        {
            InitializeComponent();
            currentHeight = (int)Height;
            currentWidth = (int)Width;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = 10;
            try
            {
                n = Convert.ToInt32(nFigures.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR", ex.Message);
            }

            Generate_Shapes(n);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            currentHeight = (int)e.NewSize.Height;
            currentWidth = (int)e.NewSize.Width;
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            mainCanvas.Children.Clear();
        }

        private void Generate_Shapes(int n)
        {
            Random rndShapeType = new Random(DateTime.Now.Millisecond);
            Random rndStyle = new Random(DateTime.Now.Second);
            Random rndPosition = new Random(DateTime.Now.Millisecond);
            Random rndSize = new Random(DateTime.Now.Minute);

            for (int i=0; i <n; i++)
            {
                Shape currentShape;
                int shapeType = rndShapeType.Next(0, 3);
                bool isPolygon = false;

                if (shapeType == 0)
                    currentShape = new Ellipse();
                else if (shapeType == 1)
                    currentShape = new Rectangle();
                else
                {
                    Polygon polygon = new Polygon(); 
                    PointCollection points = new PointCollection();
                    Random rnd = new Random();

                    int pointsCount = rnd.Next(5, 21);
                    int x, y;
                    for (int j = 0; j < pointsCount; j++)
                    {
                        x = rnd.Next(0, 200);
                        y = rnd.Next(0, 100);
                        points.Add(new Point(x, y));
                    }
                    polygon.Points = points;
                    currentShape = polygon;
                    isPolygon = true;
                }
                

                int shapeStyle = rndStyle.Next(1, 4);
                String styleName = "style" + shapeStyle.ToString();
                Style currentStyle = (Style)this.FindResource(styleName);
                currentShape.Style = currentStyle;

                if(!isPolygon)
                {
                    currentShape.Width = rndSize.Next(10, 200);
                    currentShape.Height = rndSize.Next(10, 100);
                }

                mainCanvas.Children.Add(currentShape);
                Canvas.SetLeft(currentShape, rndPosition.Next(0, currentWidth));
                Canvas.SetTop(currentShape, rndPosition.Next(0, currentHeight));
            }
        }
    }
}
