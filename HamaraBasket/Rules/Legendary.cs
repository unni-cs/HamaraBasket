namespace HamaraBasket.Rules
{
    public class Legendary : BaseRule, IRule
    {
        public override TProduct Run<TProduct>(TProduct product)
        {
            QualityChange = 0;
            return base.Run(product);
        } 
    }
}
