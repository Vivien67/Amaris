using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace ParkPrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ParkingInput parkingInput { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = parkingInput= new ParkingInput();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (parkingInput.ParkRate == EparkRate.ParkRate0)
            {
                MessageBox.Show("Merci de sélectionner un forfait.");
                labelPrice.Content = string.Empty;
            }
            else
            {
                ParkRate parkRate = new ParkRate(parkingInput.ParkRate);

                int price = parkRate.CalculatePrice(parkingInput.ParkDuration);

                var culture = CultureInfo.GetCultureInfo("fr-CA");
                var mutableNfi = (NumberFormatInfo)culture.NumberFormat.Clone();

                labelPrice.Content = price.ToString("C2", mutableNfi);
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
