namespace AuthAPI.Services;

public interface IUserService
{
    Task<UserDto> AuthenticateAsync(string username, string password);
}