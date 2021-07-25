namespace HamaraBasket.Rules
{
    public class MovieTicket : BaseRule , IRule
    {
        public override TProduct Run<TProduct>(TProduct product)
        {
            QualityChange = 1;

            if(product.SellBy == 0)
            {
                product.Quality = 0;
                return product;
            }

            if (product.SellBy <= 5)
            {
                QualityChange = 3;
                
            }
            else if (product.SellBy <= 10)
            {
                QualityChange = 2;
            }

            return base.Run(product);
        }
    }
}
