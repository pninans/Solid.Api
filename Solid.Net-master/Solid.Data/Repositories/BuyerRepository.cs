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
        public Buyer AddBuyer(Buyer buyer)
        {
            _context.BuyerList.Add(buyer);
            return buyer;
        }
        public void DeleteBuyer(int id)
        {
            _context.BuyerList.Remove(_context.BuyerList.Find(u => u.Id == id));
        }
        public Buyer GetById(int id)
        {
            return _context.BuyerList.Find(u => u.Id == id);
        }
        public List<Buyer> GetBuyers()
        {
            return _context.BuyerList;
        }
        public Buyer UpdateBuyer(int id, Buyer buyer)
        {
            var updateBuyer = _context.BuyerList.Find(u => u.Id == id);
            if (updateBuyer != null)
            {
                updateBuyer.Name = buyer.Name;
                updateBuyer.Phone = buyer.Phone;
                updateBuyer.ProductId = buyer.ProductId;
                return updateBuyer;
            }
            return null;
        }

    }
    }
