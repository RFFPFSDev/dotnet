namespace AuthAPI.Services;

public interface IUserService
{
    UserDto Authenticate(string username, string password);

    void SaveRefreshToken(string userName, string refreshToken);

    string GetRefreshToken(string userName);
}