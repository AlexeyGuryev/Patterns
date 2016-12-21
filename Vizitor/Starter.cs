using Vizitor;

namespace Patterns.Vizitor
{
    public class Starter : IStarter
    {
        public string Name
        {
            get { return "Visitor"; }
        }

        public void Run()
        {
            var products = new BaseProduct[] {new VegProduct(), new MilkProduct()};
            var visitor = new ProductStorage();
            foreach (var product in products)
            {
                product.Accept(visitor);
            }
        }
    }
}
