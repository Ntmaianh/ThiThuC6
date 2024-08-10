using API.Repository;
using Domain;

namespace API.Service
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }
        public bool Create(Product product)
        {
           return _repository.Create(product);
        }

        public bool Delete(Guid id)
        {
          return  _repository.Delete(id);
        }

        public Product GetProductById(Guid id)
        {
           return _repository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
           return _repository.GetProducts();
        }

        public bool Update(Product product)
        {
            return _repository.Update(product);
        }
    }
}
