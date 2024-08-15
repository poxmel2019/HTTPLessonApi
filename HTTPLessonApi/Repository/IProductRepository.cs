using HTTPLessonApi.Models;
using System.Collections.Generic;

namespace HTTPLessonApi.Repository
{
    public interface IProductRepository
    {
        //List<Product> Products { get; set; }
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        List<Product> GetProductByName(string name);
        
    }
}
