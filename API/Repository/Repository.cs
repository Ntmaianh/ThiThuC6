using Domain;
using Domain.Models;

namespace API.Repository
{
    public class Repository : IRepository
    {
        ThiThuC6Context _context;
        public Repository()
        {
            _context = new ThiThuC6Context();
        }
        public bool Create(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Product GetProductById(Guid id)
        {
            var product = _context.Products.Find(id);
            return product!;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public bool Update(Product product)
        {
            var productUpdate = _context.Products.Find(product.Id);
            if (productUpdate != null)
            {
                productUpdate.Name = product.Name;
                productUpdate.Price = product.Price;
                _context.Products.Update(productUpdate);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
