namespace HamaraBasket.Rules
{
    public class IndianWine : BaseRule , IRule
    {
        public override TProduct Run<TProduct>(TProduct product)
        {
            QualityChange = 1;
            return base.Run(product);
        }        
    }
}
