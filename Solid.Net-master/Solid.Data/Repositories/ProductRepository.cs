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
        public Product AddProduct(Product product)
        {
            _context.ProductList.Add(product);
            return product;
        }
        public void DeleteProduct(int id)
        {
            _context.ProductList.Remove(_context.ProductList.Find(u => u.Id == id));
        }
        public Product GetById(int id)
        {
            return _context.ProductList.Find(u => u.Id == id);
        }
        public List<Product> GetProducts()
        {
            return _context.ProductList;
        }
        public Product UpdateProduct(int id, Product product)
        {
            var updateProduct = _context.ProductList.Find(u => u.Id == id);
            if (updateProduct != null)
            {
                updateProduct.Name = product.Name;
                updateProduct.Price = product.Price;
                updateProduct.Status = product.Status;
                return updateProduct;
            }
            return null;
        }
    }
}
