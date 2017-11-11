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
        public List<TimeOption> TimeOptions { get; set; }

        public MainWindow()
        {
            TimeOptions = new List<TimeOption>();
            TimeOptions.Add(new TimeOption("6 second text", 6000));
            TimeOptions.Add(new TimeOption("25 minutes", 1500000));
            TimeOptions.Add(new TimeOption("30 minutes", 1800000));
            InitializeComponent();
            this.DataContext = this;
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

        private void TimeChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(TimeChoice.SelectedValue.ToString());
        }

    }
}