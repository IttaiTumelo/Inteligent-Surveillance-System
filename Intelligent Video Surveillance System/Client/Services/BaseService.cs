namespace Intelligent_Video_Surveillance_System.Client.Services
{
    public class BaseService
    {
        protected readonly HttpClient _httpClient;
        public BaseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
