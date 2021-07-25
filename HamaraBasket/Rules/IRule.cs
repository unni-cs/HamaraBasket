using HamaraBasket.Models;

namespace HamaraBasket.Rules
{
    public interface IRule
    {
        public int QualityChange { get; set; }
        TProduct Run<TProduct>(TProduct product) where TProduct : IProduct;
    }
}
