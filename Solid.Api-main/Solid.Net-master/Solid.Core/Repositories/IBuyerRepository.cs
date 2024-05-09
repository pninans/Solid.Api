using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IBuyerRepository
    {
        IEnumerable<Buyer> GetBuyers();
        Buyer GetById(int id);
        Task<Buyer> AddBuyerAsync(Buyer buyer);
        Task<Buyer> UpdateBuyerAsync(int id, Buyer buyer);
        Task DeleteBuyerAsync(int id);


    }

}
