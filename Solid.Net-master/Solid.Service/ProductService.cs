using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }
        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }
        public void UpdateProduct(int id, Product product)
        {
            _productRepository.UpdateProduct(id, product);
        }
        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }

    }
}
