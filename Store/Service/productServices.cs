using Store.Entiies;
using Store.Service;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new()
    {
          new Product { Id = 1, Name = "Laptop", Description = "Apple MacPro", Model = "XPS 15", Price = 1200, Stock = 1 },
          new Product { Id = 2, Name = "Phone", Description = "Sumsung galaxy smartphone", Model = "Galaxy S25", Price = 800, Stock = 0 },
          new Product { Id = 3, Name = "Headphones", Description = "Noise-cancelling headphones", Model = "WH-1000XM5", Price = 150, Stock = 2 },
           new Product { Id = 1, Name = "Desktop", Description = "Lenovo", Model = "note 15", Price = 1500, Stock = 5 },
          new Product { Id = 2, Name = "mouse", Description = "laysor mouse", Model = "model10", Price = 50, Stock = 20 },
          new Product { Id = 3, Name = "Keyboard", Description = "light-keyboard", Model = "Hydse-1000XM5", Price = 60, Stock = 2 }
    };

    public Product Create(CreateProductDto dto)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAll() => _products;

    public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
}

