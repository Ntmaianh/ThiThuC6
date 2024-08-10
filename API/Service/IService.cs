using Domain;

namespace API.Service
{
    public interface IService
    {
        List<Product> GetProducts();
        Product GetProductById(Guid id);
        bool Create(Product product);
        bool Update(Product product);
        bool Delete(Guid id);
    }
}
