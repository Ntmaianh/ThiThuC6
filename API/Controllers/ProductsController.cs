using API.Service;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IService _service;

        public ProductsController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var products = _service.GetProducts();
            return Ok(products);
        }
          [HttpGet("getById")]
        public IActionResult GetById(Guid Id)
        {
            var products = _service.GetProductById(Id);
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _service.Create(product);
            return Ok();
        }
        
        [HttpPut]
        public IActionResult UpDate(Product product)
        {
            _service.Update(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid Id)
        {
            _service.Delete(Id);
            return Ok();
        }
    }
}
