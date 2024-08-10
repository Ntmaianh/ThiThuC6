using Domain;

namespace API.Repository
{
    public interface IRepository
    {
        List<Product> GetProducts();
        Product GetProductById(Guid id);
        bool Create (Product product);
        bool Update (Product product);
        bool Delete (Guid id);
    }
}
