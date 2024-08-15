using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using HTTPLessonApi.Models;
using HTTPLessonApi.Repository;
using System.Linq;

namespace HTTPLessonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpGetController : ControllerBase
    {

        private readonly IProductRepository _productRepository = new ProductRepository();

        [HttpGet("get-all-products")]
        public async Task<IActionResult> GetAllProducts()
        {

            var products = _productRepository.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("get-product-by-id/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return NoContent();
            }
            return Ok(product);
        }

        [HttpGet("get-product-by-name/{name}")]
        public async Task<IActionResult> GetProductByName(string name)
        {
            var product = _productRepository.GetProductByName(name);
            if (product == null)
            {
                return NoContent();
            }
            return Ok(product);
        }

        


    }
}
