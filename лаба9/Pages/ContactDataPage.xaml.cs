using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MultiPageForm.Pages
{
    public partial class ContactDataPage : Page
    {
        public ContactDataPage()
        {
            InitializeComponent();
            DataContext = MainWindow.FormData;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(EmailTextBox.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Пожалуйста, введите корректный email", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(PhoneTextBox.Text) ||
                !PhoneTextBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Пожалуйста, введите корректный номер телефона", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            NavigationService.Navigate(new AddressPage());
        }
    }
}