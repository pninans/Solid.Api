using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class SellerRepository : ISellerRepository
    {
        private readonly DataContext _context;

        public SellerRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Seller> AddSellerAsync(Seller seller)
        {
            _context.SellerList.Add(seller);
            await _context.SaveChangesAsync();
            return seller;
        }
        public async Task DeleteSellerAsync(int id)
        {
            _context.SellerList.Remove(_context.SellerList.ToList().Find(u => u.Id == id));
            await _context.SaveChangesAsync();
        }
        public Seller GetById(int id)
        {
            return _context.SellerList.ToList().Find(u => u.Id == id);
        }
        public IEnumerable<Seller> GetSellers()
        {
            return _context.SellerList;
        }
        public async Task<Seller> UpdateSellerAsync(int id, Seller seller)
        {
            var updateSeller = _context.SellerList.ToList().Find(u => u.Id == id);
            if (updateSeller != null)
            {
                updateSeller.Name = seller.Name;
                updateSeller.Phone = seller.Phone;
                return updateSeller;
            }
            await _context.SaveChangesAsync();
            return null;
        }


    }
}
