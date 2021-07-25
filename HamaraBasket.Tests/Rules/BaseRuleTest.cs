using HamaraBasket.Models;
using HamaraBasket.Rules;
using HamaraBasket.Shared;
using Xunit;

namespace HamaraBasket.Tests.Rules
{
    public class BaseRuleTest
    {
        IProduct product;
        MockBaseRule DefaultRule;
        public BaseRuleTest()
        {
            DefaultRule = new MockBaseRule();
        }


        [Fact]
        public void BaseRule_WithGeneralProduct_ShouldDecreaseQuality()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.General,
                SellBy = 10,
                Quality = 10,
                Name = "Apple"
            };

            //When
            var result = DefaultRule.Run(product);

            //Then
            Assert.Equal(9,result.Quality );
            Assert.Equal(9, result.SellBy);
        }


        [Fact]
        public void BaseRule_WithGeneralProductSellByReachedThreshhold_ShouldDecreaseQualityTwice()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.General,
                SellBy = 0,
                Quality = 10,
                Name = "Apple"
            };

            //When
            var result = DefaultRule.Run(product);

            //Then
            Assert.Equal(8, result.Quality);
            Assert.Equal(0, result.SellBy);
        }

        [Fact]
        public void BaseRule_WithGeneralProductQualityAtMinimum_ShouldNotDecreaseQuality()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.General,
                SellBy = 0,
                Quality = 0,
                Name = "Apple"
            };

            //When
            var result = DefaultRule.Run(product);

            //Then
            Assert.Equal(0, result.Quality);
            Assert.Equal(0, result.SellBy);
        }
    }

    public class MockBaseRule : BaseRule
    {
       public IProduct Run(IProduct product, int? quality)
        {
            return base.Run(product);
        }
    }
}
