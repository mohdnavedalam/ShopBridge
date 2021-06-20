using ShopBridge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services.ProductServices
{
    public interface IProductService
    {
        // Get All Products
        Task<ServiceResponse<List<Product>>> GetAllProducts();

        // Add New Product
        Task<ServiceResponse<List<Product>>> AddProduct(Product newProduct);

        // Update Product
        Task<ServiceResponse<Product>> UpdateProduct(Product updatedProduct);

        // Delete Product
        Task<ServiceResponse<List<Product>>> DeleteProduct(int id);
    }
}
