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

        public List<Seller> GetSellers()
        {
            return _sellerRepository.GetSellers();
        }

        public Seller GetById(int id)
        {
            return _sellerRepository.GetById(id);
        }
        public void AddSeller(Seller seller)
        {
            seller = _sellerRepository.AddSeller(seller);
            
        }
        public void UpdateSeller(int id, Seller seller)
        {
            seller= _sellerRepository.UpdateSeller(id, seller);          
        }
        public  void DeleteSeller(int id)
        {
            _sellerRepository.DeleteSeller(id);
        }

       
    }
}
