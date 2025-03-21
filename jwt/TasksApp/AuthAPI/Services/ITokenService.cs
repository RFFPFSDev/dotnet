namespace AuthAPI.Services;

public interface ITokenService
{
    string GenerateJwtToken(UserDto user);
    string GenerateRefreshToken(string userName);
    string GetUserNameFromRefreshToken(string refreshToken);
}
