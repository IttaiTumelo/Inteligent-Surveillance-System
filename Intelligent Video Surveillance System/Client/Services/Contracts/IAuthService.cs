using Intelligent_Video_Surveillance_System.Shared.Models;

namespace Intelligent_Video_Surveillance_System.Client.Services.Contracts
{
    public interface IAuthService
    {
        Task<string> Login(UserLoginDTo request);
        Task<string> Register(UserEntity request);
    }
}
