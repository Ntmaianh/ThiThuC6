using Domain;

namespace BlazorServer.Service
{
    public class Service : IService
    {
        HttpClient _httpClient;
        public Service()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7238");
        }
        public async Task Create(Product product)
        {
            await _httpClient.PostAsJsonAsync("api/Products", product);

        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"api/Products?Id={id}");
        }

        public Task<Product> GetProductById(Guid id)
        {
            var product = _httpClient.GetFromJsonAsync<Product>($"api/Products/getById?Id={id}");
            return product;
        }

        public Task<List<Product>> GetProducts()
        {
            var repo = _httpClient.GetFromJsonAsync<List<Product>>("api/Products");

            return repo;
        }

        public async Task Update(Product product)
        {
            await _httpClient.PutAsJsonAsync("api/Products", product);
        }
    }
}
