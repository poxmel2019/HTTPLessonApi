using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HTTPLessonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpPostController : ControllerBase
    {
        [HttpPost("add-product")]
        public async Task<IActionResult> AddProduct()
        {
            return Ok();
        }
    }
}
