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

namespace Lab1Ivan_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetSquare_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(tbA.Text, out double A) &&
                double.TryParse(tbH.Text, out double H))
            {
                Trialngle trialngle = new Trialngle(A, H);

                MessageBox.Show($"Square: {trialngle.GetSquare()}", "Result!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Incorrect data!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnGetPerimetr_Click(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(tbA.Text, out double A) &&
                double.TryParse(tbB.Text, out double B) &&
                double.TryParse(tbC.Text, out double C))
            {

                Trialngle trialngle = new Trialngle(A, B, C);

                MessageBox.Show($"Perimetr: {trialngle.GetPerimetr()}", "Result!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Incorrect data!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
