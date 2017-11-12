using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        public Timer eyeRestTimer = new Timer();

        public MainWindow()
        {
            TimeOptions = new List<TimeOption>();
            TimeOptions.Add(new TimeOption("25 minutes", 1500000));
            TimeOptions.Add(new TimeOption("30 minutes", 1800000));
            TimeOptions.Add(new TimeOption("6 second test", 6000));
            InitializeComponent();
            this.DataContext = this;
        }

        public void About(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }
        public void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void cboTimeChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeOption selectedTimeOption;
            selectedTimeOption = (TimeOption) cboTimeChoice.SelectedItem;
            SetTimer(selectedTimeOption.Duration);
            txtbTimerStatus.Text = selectedTimeOption.Name;
        }

        public void SetTimer(int timerDuration)
        {
            if (eyeRestTimer.Enabled == false)
            {

                eyeRestTimer.Elapsed += OnTimedEvent;
                eyeRestTimer.Interval = timerDuration;
                eyeRestTimer.Enabled = true;
            }
        }

        public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            MessageBox.Show("Please take a break and rest your eyes.", "Rest Your Eyes - Message");
            eyeRestTimer.Enabled = false;
        }

    }
}