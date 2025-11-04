using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PalerWpfApp
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

        private void BuyNow_Click(object sender, RoutedEventArgs e)
        {
            if (PerfumeSelector.SelectedItem is ComboBoxItem selectedItem)
            {
                string perfumeName = selectedItem.Content.ToString();
                string price = PriceText.Text.Replace("Price: ", "");

                MessageBox.Show(
                    $"You bought {perfumeName} for {price}. Thank you for shopping at Paler Fragrance Perfume!",
                    "Purchase Successful",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(
                    "Please select a perfume first before buying.",
                    "No Selection",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}
    }
}