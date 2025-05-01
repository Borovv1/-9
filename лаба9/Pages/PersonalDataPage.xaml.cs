using System.Windows;
using System.Windows.Controls;

namespace MultiPageForm.Pages
{
    public partial class PersonalDataPage : Page
    {
        public PersonalDataPage()
        {
            InitializeComponent();
            DataContext = MainWindow.FormData;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите фамилию", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (BirthDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Пожалуйста, выберите дату рождения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            NavigationService.Navigate(new ContactDataPage());
        }
    }
}