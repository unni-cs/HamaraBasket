using HamaraBasket.Rules;
using HamaraBasket.Shared;
using System.Collections.Generic;
using HamaraBasket.Models;

namespace HamaraBasket
{
    public static class RuleEngine
    { 
        public static IList<TProduct> Run<TProduct>(IList<TProduct> products) where TProduct: IProduct
        {
            foreach(var product in products)
            {
                GetRule(product.ProductType).Run(product);
            }

            return products;
        }

        private static IRule GetRule(ProductType productType)
        {
            return productType switch
            {
                ProductType.IndianWine => new IndianWine(),
                ProductType.Legendary => new Legendary(),
                ProductType.MovieTicket => new MovieTicket(),
                _ => new General(),
            };
        }
    }
}
