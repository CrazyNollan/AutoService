using AutoService.Business.Enums;
using System.Threading.Tasks;

namespace AutoService.Business.Interfaces
{
    public interface IUserManager
    {
        Task<LoginResult> LoginAsync(string login, string password);

        Task<RegisterResult> RegisterAsync(string name, string surname, int tokenNumber, string login, string password);
    }
}