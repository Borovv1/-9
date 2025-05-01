using System.Windows;
using System.Windows.Controls;

namespace MultiPageForm.Pages
{
    public partial class AddressPage : Page
    {
        public AddressPage()
        {
            InitializeComponent();
            DataContext = MainWindow.FormData;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CityTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите город", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(StreetTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите улицу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(HouseNumberTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите номер дома", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var data = MainWindow.FormData;
            string message = $"Данные формы:\n\nЛичные данные:\nИмя: {data.FirstName}\nФамилия: {data.LastName}\n" +
                           $"Дата рождения: {data.BirthDate:dd.MM.yyyy}\n\nКонтактные данные:\nEmail: {data.Email}\n" +
                           $"Телефон: {data.Phone}\n\nАдрес:\nГород: {data.City}\nУлица: {data.Street}\n" +
                           $"Дом: {data.HouseNumber}\nКвартира: {data.ApartmentNumber ?? "не указано"}";

            MessageBox.Show(message, "Данные формы", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}