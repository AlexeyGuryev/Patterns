namespace Vizitor
{
    public interface IVisitor
    {
        void VisitMilkProduct(MilkProduct product);
        void VisitVegProduct(VegProduct product);
    }
}