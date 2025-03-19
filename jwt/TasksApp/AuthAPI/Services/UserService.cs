namespace AuthAPI.Services;

public class UserService : IUserService
{
    public async Task<UserDto> AuthenticateAsync(string username, string password)
    {
        if (username == "testuser" && password == "password")
        {
            return new UserDto { Id = 1, Username = "testuser", Role = "Admin" };
        }

        return null;
    }
}