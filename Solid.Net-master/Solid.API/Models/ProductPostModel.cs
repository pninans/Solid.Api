namespace Solid.API.Models
{
    public class ProductPostModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }

    }
}
