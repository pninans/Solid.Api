using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface ISellerService
    {
        IEnumerable<Seller> GetSellers();
        Seller GetById(int id);
        Task<Seller> AddSellerAsync(Seller seller);
        Task<Seller> UpdateSellerAsync(int id, Seller seller);
        Task DeleteSellerAsync(int id);
    }
}

