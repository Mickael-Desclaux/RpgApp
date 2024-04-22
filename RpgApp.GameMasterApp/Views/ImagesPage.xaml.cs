using Microsoft.Win32;
using RpgApp.GameMasterApp.Services;
using System.IO;
using System.Windows.Controls;
using Image = RpgApp.GameMasterApp.Models.Image;

namespace RpgApp.GameMasterApp.Views
{
    /// <summary>
    /// Logique d'interaction pour ImagesPage.xaml
    /// </summary>
    public partial class ImagesPage : Page
    {
        protected Image Image = new();

        public ImagesPage()
        {
            InitializeComponent();
        }

        protected async void AddImage_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg;*.gif)|*.png;*.jpeg;*.jpg;*.gif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                byte[] fileBytes = File.ReadAllBytes(filePath);

                Image.ImageData = fileBytes;

                //TODO : See if there is a way for dependency injection
                ImageService imageService = new ImageService();
                await imageService.CreateImageAsync(Image);
            }
        }
    }
}
