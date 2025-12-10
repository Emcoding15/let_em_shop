using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProtectedController : ControllerBase
    {
        [HttpGet("secret")]
        [Authorize(Roles = "Admin")]
        public IActionResult Secret()
        {
            return Ok("You are authenticated as an Admin and can access this protected endpoint!");
        }
    }
}
