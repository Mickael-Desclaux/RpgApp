using RpgApp.GameMasterApp.Services;
using RpgApp.GameMasterApp.Views;
using System.Net.Http;
using System.Windows;

namespace RpgApp.GameMasterApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new ImagesPage());
        }
    }
}