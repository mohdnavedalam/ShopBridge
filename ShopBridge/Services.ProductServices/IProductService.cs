using ShopBridge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetAllProducts();
        Task<ServiceResponse<List<Product>>> AddProduct(Product newProduct);
        Task<ServiceResponse<Product>> UpdateProduct(Product updatedProduct);
        Task<ServiceResponse<List<Product>>> DeleteProduct(int id);
    }
}
