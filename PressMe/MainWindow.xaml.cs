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

namespace PressMe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        private int _counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var b = (sender as Button);
            Canvas.SetLeft(b, random.Next((int)Width - 150));
            Canvas.SetTop(b, random.Next((int)Height - 100));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = _counter;
            _counter++;
        }
    }
}
