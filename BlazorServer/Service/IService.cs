using Domain;

namespace BlazorServer.Service
{
    public interface IService
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(Guid id);
        Task Create (Product product);
        Task Update (Product product);
        Task Delete (Guid id);
    }
}
