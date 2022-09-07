using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeActive.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TestAuthController : ControllerBase
    {
        [HttpGet]
        public async Task<OkObjectResult> Get()
        {
            Console.WriteLine("testGit");
            return Ok("Merge!");
        }
    }
}
