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
        Buyer AddBuyer(Buyer buyer);
        Buyer UpdateBuyer(int id, Buyer buyer);
        void DeleteBuyer(int id);


    }

}
