using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Product> AddProductAsync(Product product)
        {
            _context.ProductList.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task  DeleteProductAsync(int id)
        {
            _context.ProductList.Remove(_context.ProductList.ToList().Find(u => u.Id == id));
            await _context.SaveChangesAsync();
        }
        public Product GetById(int id)
        {
            return _context.ProductList.ToList().Find(u => u.Id == id);
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.ProductList;
        }
        public async Task<Product> UpdateProductAsync(int id, Product product)
        {
            var updateProduct = _context.ProductList.ToList().Find(u => u.Id == id);
            if (updateProduct != null)
            {
                updateProduct.Name = product.Name;
                updateProduct.Price = product.Price;
                updateProduct.Status = product.Status;
                updateProduct.SellerId = product.SellerId;
                updateProduct.Seller=product.Seller;
                updateProduct.buyer=product.buyer;
                updateProduct.BuyerId = product.BuyerId;
                return updateProduct;
            }
            await _context.SaveChangesAsync();
            return null;
        }
    }
}
