namespace Vizitor
{
    public class MilkProduct : BaseProduct
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitMilkProduct(this);
        }
    }
}
