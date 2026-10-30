[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    [Authorize]
    [HttpGet("me")]
    public IActionResult Me()
    {
        return Ok(new
        {
            Name = User.Identity?.Name,
            Email = User.Claims
                .FirstOrDefault(x =>
                    x.Type == "preferred_username")
                ?.Value
        });
    }
}