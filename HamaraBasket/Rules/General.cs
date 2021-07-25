namespace HamaraBasket.Rules
{
    public class General : BaseRule, IRule
    {         
        public override TProduct Run<TProduct>(TProduct product)
        {
            return base.Run(product);
        }
    }
}
