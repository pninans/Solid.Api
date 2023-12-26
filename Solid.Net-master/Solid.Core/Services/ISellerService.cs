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
        void AddSeller(Seller seller);
        void UpdateSeller(int id, Seller seller);
        void DeleteSeller(int id);
    }
}

