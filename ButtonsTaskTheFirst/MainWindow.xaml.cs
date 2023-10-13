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

namespace ButtonsTaskTheFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            byte r = Convert.ToByte(Random.Shared.Next(0, 256));
            byte g = Convert.ToByte(Random.Shared.Next(0, 256));
            byte b = Convert.ToByte(Random.Shared.Next(0, 256));
            ((Button)sender).Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            StringBuilder message = new StringBuilder();
            message.AppendLine("Button Information:");
            message.AppendLine($"Background Color - R: {r}, G: {g}, B: {b}");
            message.AppendLine($"Name: {((Button)sender).Name}");
            message.AppendLine($"Width: {((Button)sender).ActualWidth}");
            message.AppendLine($"Height: {((Button)sender).ActualHeight}");
            MessageBox.Show(message.ToString());
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Title = ((Button)sender).Content.ToString();
            MyGrid.Children.Remove(((Button)sender));

        }
    }
}
