using System.Windows;

namespace MultiPageForm
{
    public partial class MainWindow : Window
    {
        public static FormDataViewModel FormData { get; } = new FormDataViewModel();

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.PersonalDataPage());
        }
    }
}