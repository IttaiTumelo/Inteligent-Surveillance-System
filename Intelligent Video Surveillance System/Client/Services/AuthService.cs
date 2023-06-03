global using System.Net.Http.Json;
global using Intelligent_Video_Surveillance_System.Client.Services.Contracts;
global using Intelligent_Video_Surveillance_System.Shared.Models;


namespace Intelligent_Video_Surveillance_System.Client.Services
{
    public class AuthService : BaseService, IAuthService
    {
        public AuthService(HttpClient httpClient) : base(httpClient) {}
        
        // Function to login
        public async Task<string> Login(UserLoginDTo request)
        {
            var response = await _httpClient.PostAsJsonAsync<UserLoginDTo>("api/login", request);

            // check if login attemopt was successful
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new ApplicationException(error);
            }

            return await response.Content.ReadAsStringAsync();
        }

        // Function to register
        public Task<string> Register(UserEntity request)
        {
            throw new NotImplementedException();
        }
    }
}
