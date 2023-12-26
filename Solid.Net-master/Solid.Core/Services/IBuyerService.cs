using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IBuyerService
    {
        IEnumerable<Buyer> GetBuyers();

        Buyer GetById(int id);
        void AddBuyer(Buyer buyer);
        void UpdateBuyer(int id, Buyer buyer);
        void DeleteBuyer(int id);
    }
}
