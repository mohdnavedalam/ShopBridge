using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.Models;
using ShopBridge.Services.ProductServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetAllProducts());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product updatedProduct)
        {
            ServiceResponse<Product> serviceResponse = await _productService.UpdateProduct(updatedProduct);
            if (serviceResponse.Data == null)
                return NotFound(serviceResponse);
            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product newProduct)
        {
            return Ok(await _productService.AddProduct(newProduct));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            ServiceResponse<List<Product>> serviceResponse = await _productService.DeleteProduct(id);
            if (serviceResponse.Data == null)
                return NotFound(serviceResponse);
            return Ok(serviceResponse);
        }
    }
}
