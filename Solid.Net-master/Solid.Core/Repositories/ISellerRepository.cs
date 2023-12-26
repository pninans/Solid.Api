using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ISellerRepository
    {
        IEnumerable<Seller> GetSellers();
        Seller GetById(int id);
        Seller AddSeller(Seller seller);
        Seller UpdateSeller(int id, Seller seller);
        void DeleteSeller(int id);
    }
}
