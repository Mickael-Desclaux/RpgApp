using RpgApp.GameMasterApp.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace RpgApp.GameMasterApp.Services
{
    public class ImageService() : GenericService, IImageService
    {
        public async Task<Image> GetImageByIdAsync(int imageId)
        {
            var response = await HttpClient.GetAsync($"api/image/GetById/{imageId}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            var image = JsonSerializer.Deserialize<Image>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return image ?? throw new HttpRequestException("Image data is null.", null, HttpStatusCode.NoContent);
        }

        public async Task CreateImageAsync(Image image)
        {
            var response = await HttpClient.PostAsJsonAsync("api/image/Add", image);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateImageAsync(Image image)
        {
            var response = await HttpClient.PutAsJsonAsync($"api/image/Update/{image.Id}", image);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteImageAsync(Image image)
        {
            var response = await HttpClient.DeleteAsync($"api/image/Delete/{image.Id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
