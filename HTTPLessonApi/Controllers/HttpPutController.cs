using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HTTPLessonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpPutController : ControllerBase
    {
        [HttpPut("update-product-count/{id}")]
        public async Task<IActionResult> UpdateProductCount(int id)
        {
            return Ok();
        }
    }
}
