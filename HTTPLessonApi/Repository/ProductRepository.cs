using System.Collections.Generic;
using System.Linq;
using HTTPLessonApi.Models;

namespace HTTPLessonApi.Repository
{
    public class ProductRepository : IProductRepository
    {

        public List<Product> Products;
        public ProductRepository() 
        {
            Products = new List<Product>()
            {
                new Product(1,"Bread","Breads",100),
                new Product(2, "Milk", "Milks", 200),
                new Product(3, "Egg", "Eggs", 150)
            };
        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public Product GetProductById(int id)
        {
            Product product = Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public List<Product> GetProductByName(string name)
        {
            var product = Products.Where(x => x.Name.ToLower() == name.ToLower());
            return product.ToList();
        }
    }
}
