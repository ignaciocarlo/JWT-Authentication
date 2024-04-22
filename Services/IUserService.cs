using JWTAuthentication.Models;

namespace JWTAuthentication.Services
{
    public interface IUserService
    {
        string Login(User user);
    }
}
