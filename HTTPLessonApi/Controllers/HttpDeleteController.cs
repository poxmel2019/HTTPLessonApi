using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HTTPLessonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpDeleteController : ControllerBase
    {


        [HttpDelete("delete-product-by-id")]
        public async Task<IActionResult> DeleteProductById(int id)
        {
            return Ok();
        }

    }
}
