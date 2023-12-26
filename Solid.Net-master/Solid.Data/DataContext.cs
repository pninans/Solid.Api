using Solid.Core.Entities;

namespace Solid.Data
{
    public class DataContext
    {
        public List<Buyer> BuyerList { get; set; }
        public List<Product> ProductList { get; set; }
        public List<Seller> SellerList { get; set; }

        public DataContext()
        {
            BuyerList = new List<Buyer>();
            BuyerList.Add(new Buyer() { Id=1,Name="pnina"});
            BuyerList.Add(new Buyer() { Id = 2, Name = "rivki" });
            ProductList = new List<Product>();
            ProductList.Add(new Product() { Id=1,Name="pn"});
            ProductList.Add(new Product() { Id=2,Name="ri"});
            SellerList = new List<Seller>();
            SellerList.Add(new Seller() { Id=1,Name="p"});
            SellerList.Add(new Seller() { Id=2,Name="r"});
        }
    }
}