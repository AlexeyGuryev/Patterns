using System;

namespace Vizitor
{
    public class ProductStorage : IVisitor
    {
        private BaseProduct _product;

        public void VisitMilkProduct(MilkProduct product)
        {
            _product = product;
            Store();
        }

        private void Store()
        {
            Console.WriteLine("Product {0} stored!!!", _product.GetType());
        }

        public void VisitVegProduct(VegProduct product)
        {
            _product = product;
            Store();
        }
    }
}
