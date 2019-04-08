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

namespace _352
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            StartGame a = new StartGame();
            this.Visibility = Visibility.Hidden; // Hides the button after click
            a.Show();
            this.Close(); // Closes them after
        }

        private void Resume(object sender, RoutedEventArgs e)
        {
            Resume c = new Resume();
            this.Visibility = Visibility.Hidden;
            c.Show();
            this.Close();
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
