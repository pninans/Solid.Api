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
    public class SellerService : ISellerService
    {
        private readonly ISellerRepository _sellerRepository;

        public SellerService(ISellerRepository selllerRepository)
        {
            _sellerRepository = selllerRepository;
        }

        public IEnumerable<Seller> GetSellers()
        {
            return _sellerRepository.GetSellers();
        }

        public Seller GetById(int id)
        {
            return _sellerRepository.GetById(id);
        }
        public async Task<Seller> AddSellerAsync(Seller seller)
        {
            return await _sellerRepository.AddSellerAsync(seller);

        }
        public async Task<Seller> UpdateSellerAsync(int id, Seller seller)
        {
             return await _sellerRepository.UpdateSellerAsync(id, seller);
        }
        public async Task DeleteSellerAsync(int id)
        {
            await _sellerRepository.DeleteSellerAsync(id);
        }


    }
}
