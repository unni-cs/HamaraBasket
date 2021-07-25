using HamaraBasket.Models;
using HamaraBasket.Rules;
using HamaraBasket.Shared;
using Xunit;

namespace HamaraBasket.Tests.Rules
{
    public class IndianWineTest
    {
        IProduct product;
        IndianWine rule;
        public IndianWineTest()
        {
            rule = new IndianWine();
        }

        [Fact]
        public void IndianWine_WithQualityWithinMaxLimit_ShouldIncreaseQuality()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.IndianWine,
                SellBy = 10,
                Quality = 10,
                Name = "Wine"
            };

            //When
            var result = rule.Run(product);

            //Then
            Assert.Equal(11, result.Quality);
            Assert.Equal(9, result.SellBy);
        }

        [Fact]
        public void IndianWine_WithQalityAtMaxLimit_ShouldNotIncreaseQuality()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.IndianWine,
                SellBy = 10,
                Quality = 50,
                Name = "Wine"
            };

            //When
            var result = rule.Run(product);

            //Then
            Assert.Equal(50, result.Quality);
            Assert.Equal(9, result.SellBy);
        }
    }
}
