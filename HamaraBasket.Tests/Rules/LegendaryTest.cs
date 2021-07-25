using HamaraBasket.Models;
using HamaraBasket.Rules;
using HamaraBasket.Shared;
using Xunit;

namespace HamaraBasket.Tests.Rules
{
    public class LegendaryTest
    {
        IProduct product;
        Legendary rule;
        public LegendaryTest()
        {
            rule = new Legendary();
        }

        [Fact]
        public void Legendary_WithLegendaryProduct_ShouldNotIncreaseOrDecreaseQuality()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.Legendary,
                SellBy = 10,
                Quality = 10,
                Name = "Honey"
            };

            //When
            var result = rule.Run(product);

            //Then
            Assert.Equal(10, result.Quality);
            Assert.Equal(10, result.SellBy);
        }        
    }
}
