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

namespace desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string number = "000";
        private string eyeColor = "";

        public MainWindow()
        {
            InitializeComponent();
            LoadImages(number);
        }

        private void LoadImages(string number)
        {
            Image1.Source = new BitmapImage(new Uri(number + "-zdjecie.jpg", UriKind.Relative));
            Image2.Source = new BitmapImage(new Uri(number + "-odcisk.jpg", UriKind.Relative));
        }

        private void NumberTextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            LoadImages(((TextBox)sender).Text);
        }

        private void EyeColorRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            eyeColor = ((RadioButton)sender).Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(NameTextBox.Text) || !string.IsNullOrEmpty(SurnameTextBox.Text))
            {
                MessageBox.Show($"{NameTextBox.Text} {SurnameTextBox.Text} kolor oczu {eyeColor}");
            }
            else
            {
                MessageBox.Show("Wprowadź dane");
            }
        }
    }
}