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
        public Seller AddSeller(Seller seller)
        {
            _context.SellerList.Add(seller);
            _context.SaveChanges();
            return seller;
        }
        public void DeleteSeller(int id)
        {
            _context.SellerList.Remove(_context.SellerList.ToList().Find(u => u.Id == id));
            _context.SaveChanges();
        }
        public Seller GetById(int id)
        {
            return _context.SellerList.ToList().Find(u => u.Id == id);
        }
        public IEnumerable<Seller> GetSellers()
        {
            return _context.SellerList;
        }
        public Seller UpdateSeller(int id, Seller seller)
        {
            var updateSeller = _context.SellerList.ToList().Find(u => u.Id == id);
            if (updateSeller != null)
            {
                updateSeller.Name = seller.Name;
                updateSeller.Phone = seller.Phone;
                updateSeller.Product = seller.Product;
                return updateSeller;
            }
            _context.SaveChanges();
            return null;
        }


    }
}
