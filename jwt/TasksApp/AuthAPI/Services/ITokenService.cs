namespace AuthAPI.Services;

public interface ITokenService
{
    string GenerateJwtToken(UserDto user);
}
