using HamaraBasket.Models;
using HamaraBasket.Rules;
using HamaraBasket.Shared;
using Xunit;

namespace HamaraBasket.Tests.Rules
{
    public class MovieTicketTest
    {
        IProduct product;
        MovieTicket rule;
        public MovieTicketTest()
        {
            rule = new MovieTicket();
        }


        [Fact]
        public void MovieTicket_WithProductSellByMorethanTen_ShouldIncreaseQuality()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.MovieTicket,
                SellBy = 20,
                Quality = 10,
                Name = "Movie Ticket"
            };

            //When
            var result = rule.Run(product);

            //Then
            Assert.Equal(11, result.Quality);
            Assert.Equal(19, result.SellBy);
        }

        [Fact]
        public void MovieTicket_WithProductSellByTenOrLess_ShouldIncreaseQualityByTwoUnit()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.MovieTicket,
                SellBy = 10,
                Quality = 10,
                Name = "Movie Ticket"
            };

            //When
            var result = rule.Run(product);

            //Then
            Assert.Equal(12, result.Quality);
            Assert.Equal(9, result.SellBy);
        }

        [Fact]
        public void MovieTicket_WithProductSellByFiveOrLess_ShouldIncreaseQualityByThreeUnit()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.MovieTicket,
                SellBy = 5,
                Quality = 10,
                Name = "Movie Ticket"
            };

            //When
            var result = rule.Run(product);

            //Then
            Assert.Equal(13, result.Quality);
            Assert.Equal(4, result.SellBy);
        }

        [Fact]
        public void MovieTicket_WithProductExpired_ShouldSetQualityToZero()
        {
            //Given
            product = new Product
            {
                ProductType = ProductType.MovieTicket,
                SellBy = 0,
                Quality = 10,
                Name = "Movie Ticket"
            };

            //When
            var result = rule.Run(product);

            //Then
            Assert.Equal(0, result.Quality);
            Assert.Equal(0, result.SellBy);
        }
    }
}
