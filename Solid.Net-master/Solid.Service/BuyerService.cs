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
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerRepository _buyerRepository;



        public BuyerService(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public IEnumerable<Buyer> GetBuyers()
        {
            return _buyerRepository.GetBuyers();
        }

        public Buyer GetById(int id)
        {
            return _buyerRepository.GetById(id);
        }
        public void AddBuyer(Buyer buyer)
        {
            _buyerRepository.AddBuyer(buyer);
        }
        public void UpdateBuyer(int id, Buyer buyer)
        {
            _buyerRepository.UpdateBuyer(id, buyer);
        }
        public void DeleteBuyer(int id)
        {
            _buyerRepository.DeleteBuyer(id);
        }


    }
}
