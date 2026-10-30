[HttpPost("users/invite")]
public async Task<IActionResult> InviteUser(
    InviteUserRequest request)
{
    return Ok();
}