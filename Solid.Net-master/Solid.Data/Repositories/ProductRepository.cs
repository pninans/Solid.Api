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
            _context.SaveChanges();
            return product;
        }
        public void DeleteProduct(int id)
        {
            _context.ProductList.Remove(_context.ProductList.ToList().Find(u => u.Id == id));
            _context.SaveChanges();
        }
        public Product GetById(int id)
        {
            return _context.ProductList.ToList().Find(u => u.Id == id);
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.ProductList;
        }
        public Product UpdateProduct(int id, Product product)
        {
            var updateProduct = _context.ProductList.ToList().Find(u => u.Id == id);
            if (updateProduct != null)
            {
                updateProduct.Name = product.Name;
                updateProduct.Price = product.Price;
                updateProduct.Status = product.Status;
                return updateProduct;
            }
            _context.SaveChanges();
            return null;
        }
    }
}
