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

namespace _8Dubbelfeest
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(numberOfPeopleTextBox.Text, out float people);
            float chance = 365;
            float percentage = 1;

            while (people >= 2)
            {
                people--;
                chance--;
                percentage *= chance / 365;
            }
            percentage *=  100;
            resultTextBox.Text = $"De kans op gelijke verjaardagen is {(100f - percentage):f2}%";
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberOfPeopleTextBox.Text = "1";
            numberOfPeopleTextBox.Focus();
            resultTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
