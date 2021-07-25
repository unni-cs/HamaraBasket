using HamaraBasket.Models;
      using System.Collections.Generic;
using Xunit;

namespace HamaraBasket.Tests
{
    public class RuleEngineTest
    {
        IList<IProduct> products;
        public RuleEngineTest()
        {
            products = new List<IProduct>
            {
                new Product{ Name="Product1", ProductType= Shared.ProductType.General, Quality = 10, SellBy = 10},
                new Product{ Name="Product2", ProductType= Shared.ProductType.General, Quality = 0, SellBy = 10},
                new Product{ Name="Product3", ProductType= Shared.ProductType.General, Quality = 2, SellBy = 0},
                new Product{ Name="Product4", ProductType= Shared.ProductType.IndianWine, Quality = 10, SellBy = 10},
                new Product{ Name="Product5", ProductType= Shared.ProductType.IndianWine, Quality = 50, SellBy = 10},
                new Product{ Name="Legandary", ProductType= Shared.ProductType.Legendary, Quality = 10, SellBy = 10},
                new Product{ Name="Movie Ticket1", ProductType= Shared.ProductType.MovieTicket, Quality = 10, SellBy = 11},
                new Product{ Name="Movie Ticket2", ProductType= Shared.ProductType.MovieTicket, Quality = 10, SellBy = 7},
                new Product{ Name="Movie Ticket3", ProductType= Shared.ProductType.MovieTicket, Quality = 10, SellBy = 3},
                new Product{ Name="Movie Ticket4", ProductType= Shared.ProductType.MovieTicket, Quality = 10, SellBy = 0}
            };
        }

        [Fact]
        public void RuleEngine_Run_ShouldReturnUpdatedProducts()
        {
            //Given products with valid quality and sellby

            //When
            var actual = RuleEngine.Run(products);

            //Then
            Assert.NotNull(actual);
            Assert.Equal(products.Count, actual.Count);
            Assert.IsAssignableFrom<IList<IProduct>>(actual);
        }
    }
}
