using Store.Entiies;

namespace Store.Service
{
 
        public interface IProductService
        {
            IEnumerable<Product> GetAll();
            Product? GetById(int id);
            Product Create(CreateProductDto dto); 
        }

    
}
