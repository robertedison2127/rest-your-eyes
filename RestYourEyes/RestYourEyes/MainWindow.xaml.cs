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

namespace RestYourEyes
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

        private void Set_Timer(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked set timer");
        }

        private void License(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked show license");
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}