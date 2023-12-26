using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        Product GetById(int id);
        void AddProduct(Product product);
        void UpdateProduct(int id, Product product);
        void DeleteProduct(int id);
    }
}
