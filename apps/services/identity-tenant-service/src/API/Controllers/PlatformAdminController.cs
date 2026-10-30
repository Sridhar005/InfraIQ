using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/platform-admin")]
public class PlatformAdminController : ControllerBase
{
    private readonly ITenantService _tenantService;

    public PlatformAdminController(ITenantService tenantService)
    {
        _tenantService = tenantService;
    }

    [HttpPost("tenants")]
    public async Task<IActionResult> CreateTenant(CreateTenantCommand request)
    {
        var tenantId =
            await _tenantService.CreateTenantAsync(request);

        return Ok(new
        {
            TenantId = tenantId
        });
    }
}