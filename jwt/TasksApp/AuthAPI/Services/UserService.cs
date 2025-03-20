namespace AuthAPI.Services;

public class UserService : IUserService
{
    public async Task<UserDto> AuthenticateAsync(string username, string password)
    {
        if (username == "adminuser" && password == "password")
        {
            return new UserDto { Id = 1, Username = "user123", Role = "Admin" };
        }

        if (username == "basicuser" && password == "password")
        {
            return new UserDto { Id = 1, Username = "userABC", Role = "Basic" };
        }

        return null;
    }
}