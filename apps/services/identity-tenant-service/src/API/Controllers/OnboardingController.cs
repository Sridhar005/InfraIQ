[ApiController]
[Route("api/onboarding")]
public class OnboardingController : ControllerBase
{
    [HttpPost("sso")]
    public async Task<IActionResult> ConfigureSso(
        ConfigureSsoRequest request)
    {
        return Ok();
    }
}