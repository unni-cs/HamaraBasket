using HamaraBasket.Models;

namespace HamaraBasket.Rules
{
    public abstract class BaseRule : IRule
    {
        private const int MinQuality = 0;
        private const int MaxQuality = 50;        
        private const int TwiceQualityDegrade  = -2;

        private int DefaultQulityChange = -1;

        public int QualityChange { get { return DefaultQulityChange; } set { DefaultQulityChange = value; } }

        public virtual TProduct Run<TProduct>(TProduct product) where TProduct: IProduct
        {           
            var quality = product.SellBy == 0? TwiceQualityDegrade : QualityChange;
            return ExecuteRule(product, quality);
        }

        private TProduct ExecuteRule<TProduct>(TProduct product, int quality) where TProduct : IProduct
        {
            if ((quality < 0 && product.Quality + quality >= MinQuality)||
                (quality >= 0 && product.Quality + quality <= MaxQuality))
            {
                product.Quality += quality;
            }

            if (product.ProductType != Shared.ProductType.Legendary && product.SellBy > 0)
            {
                product.SellBy += -1;
            }
            return product;
        }
    }
}
