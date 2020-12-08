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

namespace ASP_12_RadioButtonChallengeBen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Pen.Visibility = Visibility.Hidden;
            Pencil.Visibility = Visibility.Hidden;
            Tablet.Visibility = Visibility.Hidden;
            Phone.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pen.Visibility = Visibility.Hidden;
            Pencil.Visibility = Visibility.Hidden;
            Tablet.Visibility = Visibility.Hidden;
            Phone.Visibility = Visibility.Hidden;

            if (phone.IsChecked == true)
            {
                Ootput.Content = "The phone, unconventional choice.";
                Phone.Visibility = Visibility.Visible;

            }
            else if (tablet.IsChecked == true)
            {
                Ootput.Content = "A tablet, not a bad choice.";
                Tablet.Visibility = Visibility.Visible;


            }
            else if (pencil.IsChecked == true)
            {
                Ootput.Content = "A pencil, the OG tool.";
                Pencil.Visibility = Visibility.Visible;


            }
            else if (pen.IsChecked == true)
            {
                Ootput.Content = "A pen, a cooler choice that the pencil, maybe just less practical.";
                Pen.Visibility = Visibility.Visible;


            }

        }
    }
}
