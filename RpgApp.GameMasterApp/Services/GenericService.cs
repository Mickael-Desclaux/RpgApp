using System.Net.Http;

namespace RpgApp.GameMasterApp.Services
{
    public abstract class GenericService
    {
        protected HttpClient HttpClient { get; set; } = new HttpClient();
        protected GenericService() 
        {
            HttpClient.BaseAddress = new Uri("https://localhost:7209/");
        }
    }
}
