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

namespace Builder
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Canvas buildingFieldCanvas = new Canvas();


            buildingFieldCanvas.Children.Add(drawRectangle(600, 200, 2));

            builderField.Children.Add(buildingFieldCanvas);
        }


        public Rectangle drawRectangle(int height, int width, int wallThickness)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Stroke = new SolidColorBrush(Colors.Black);
            rectangle.Height = height;
            rectangle.Width = width;

            return rectangle;
        }
    }
}
