namespace AuthAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController(
        IUserService _userService,
        ITokenService _tokenService
    ) : Controller
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Models.LoginRequest model)
    {
        if (string.IsNullOrWhiteSpace(model.Username) || string.IsNullOrWhiteSpace(model.Password))
        {
            return BadRequest("Invalid login request.");
        }

        var user = await _userService.AuthenticateAsync(model.Username, model.Password);

        if (user == null)
        {
            return Unauthorized("Invalid credentials.");
        }

        var token = _tokenService.GenerateJwtToken(user);

        return Ok(new { Token = token });
    }
}