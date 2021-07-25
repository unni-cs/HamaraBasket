using HamaraBasket.Shared;

namespace HamaraBasket.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public int SellBy { get; set; }
        public int Quality { get; set; }
        public ProductType ProductType { get; set; }
        }
}
