public class TenantMiddleware
{
    private readonly RequestDelegate _next;

    public TenantMiddleware(
        RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(
        HttpContext context)
    {
        // Resolve user
        // Resolve membership
        // Resolve tenant
        // Resolve permissions

        await _next(context);
    }
}