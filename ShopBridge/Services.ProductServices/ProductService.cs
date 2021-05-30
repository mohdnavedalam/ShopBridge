using Microsoft.EntityFrameworkCore;
using ShopBridge.DataConnection;
using ShopBridge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _appDbContext;

        public ProductService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ServiceResponse<List<Product>>> AddProduct(Product newProduct)
        {
            ServiceResponse<List<Product>> serviceResponse = new ServiceResponse<List<Product>>();
            Product product = newProduct;
            await _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();
            serviceResponse.Data = _appDbContext.Products.ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Product>>> DeleteProduct(int id)
        {
            ServiceResponse<List<Product>> serviceResponse = new ServiceResponse<List<Product>>();
            try
            {
                var product = await _appDbContext.Products.FirstAsync(c => c.ID == id);
                _appDbContext.Products.Remove(product);
                await _appDbContext.SaveChangesAsync();

                serviceResponse.Data = _appDbContext.Products.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;                
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Product>>> GetAllProducts()
        {
            ServiceResponse<List<Product>> serviceResponse = new ServiceResponse<List<Product>>();
            List<Product> dbProducts = await _appDbContext.Products.ToListAsync();
            serviceResponse.Data = dbProducts;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Product>> UpdateProduct(Product updatedProduct)
        {
            ServiceResponse<Product> serviceResponse = new ServiceResponse<Product>();
            try
            {
                Product product = await _appDbContext.Products.FirstOrDefaultAsync(c => c.ID == updatedProduct.ID);
                product.ProductName = updatedProduct.ProductName;
                product.Description = updatedProduct.Description;
                product.Price = updatedProduct.Price;
                product.Quantity = updatedProduct.Quantity;
                product.Unit = updatedProduct.Unit;

                _appDbContext.Products.Update(product);
                await _appDbContext.SaveChangesAsync();

                serviceResponse.Data = product;
            }
            catch(Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
    }
}
