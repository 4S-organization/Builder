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

            TextBlock textBlock = new TextBlock();

            textBlock.Text = "4S";

            textBlock.Foreground = new SolidColorBrush(color: Colors.Black);

            Canvas.SetLeft(textBlock, 100);

            Canvas.SetTop(textBlock, 100);


            buildingFieldCanvas.Children.Add(textBlock);

            builderField.Children.Add(buildingFieldCanvas);
        }
    }
}
