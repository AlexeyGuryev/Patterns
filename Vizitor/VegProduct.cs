namespace Vizitor
{
    public class VegProduct : BaseProduct
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitVegProduct(this);
        }
    }
}
