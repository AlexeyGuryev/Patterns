namespace Vizitor
{
    public abstract class BaseProduct
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public abstract void Accept(IVisitor visitor);
    }
}
