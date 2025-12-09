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
        public IActionResult Secret()
        {
            return Ok("You are authenticated and can access this protected endpoint!");
        }
    }
}
