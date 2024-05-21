using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly DataContext _context;

        public BuyerRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Buyer> AddBuyerAsync(Buyer buyer)
        {
            _context.BuyerList.Add(buyer);
            await  _context.SaveChangesAsync();
            return buyer;
        }
        public async Task DeleteBuyerAsync(int id)
        {
            _context.BuyerList.Remove(_context.BuyerList.ToList().Find(u => u.Id == id));
            await _context.SaveChangesAsync();
        }
        public Buyer GetById(int id)
        {
            return _context.BuyerList.ToList().Find(u => u.Id == id);
        }
        public IEnumerable<Buyer> GetBuyers()
        {
            return _context.BuyerList;
        }
        public async Task<Buyer> UpdateBuyerAsync(int id, Buyer buyer)
        {
            var updateBuyer = _context.BuyerList.ToList().Find(u => u.Id == id);
            if (updateBuyer != null)
            {
                updateBuyer.Name = buyer.Name;
                updateBuyer.Phone = buyer.Phone;
               
            }
            await _context.SaveChangesAsync();
            return updateBuyer;
        }


    }
}
