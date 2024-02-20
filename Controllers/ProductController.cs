using api_ecommerce.DTOs.Responses;
using api_ecommerce.Models;
using api_ecommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("GetProductById")]
        public IActionResult GetById(int id)
        {
            var product =  _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        [Route("CreateProduct")]
        public IActionResult CreateProduct(ProductRequest prod)
        {
            _productService.CreateProduct(prod);

            return Ok();
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var productDeleted = _productService.DeleteProduct(id);

            if (productDeleted)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpPut]
        [Route("UpdateProduct/{id}")]
        public IActionResult UpdateProduct(Product product)
        {
            var productUpdate = _productService.UpdateProduct(product);

            if (productUpdate)
            {
                return Ok();
            }

            return BadRequest();
        }


    }
}
