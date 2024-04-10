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
        public async Task<Buyer> AddBuyerAsync(Buyer buyer)
        {
            return await _buyerRepository.AddBuyerAsync(buyer);
        }
        public async Task<Buyer> UpdateBuyerAsync(int id, Buyer buyer)
        {
            return await _buyerRepository.UpdateBuyerAsync(id, buyer);
        }
        public async Task DeleteBuyerAsync(int id)
        {
            await _buyerRepository.DeleteBuyerAsync(id);
        }


    }
}
