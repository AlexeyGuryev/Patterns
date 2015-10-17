using System;

namespace GoF
{
    public class AbstractFactoryStarter : IStarter
    {
        public void Run()
        {
            AbstractFactory factory = new ConcreteFactory();
            IProduct product = new Product1();
            product.SetUp("Abibas");
            factory.Calculator.Product = product;
            factory.Calculator.Calculate();
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IProduct Product { get; }
        public abstract ICalculator Calculator { get; }
    }

    public interface IProduct
    {
        void ShowInfo();
        void SetUp(string name);
    }

    public interface ICalculator
    {
        void Calculate();
        IProduct Product { set; }
    }

    public class Product1 : IProduct
    {
        private string _name;

        public void SetUp(string name)
        {
            _name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Product1 {0} initialized!", _name);
        }
    }

    public class ProductCalculator1 : ICalculator
    {
        private IProduct _product;

        public IProduct Product
        {
            set
            {
                _product = value;
            }
        }

        public void Calculate()
        {
            Console.WriteLine("Caution! The product calculation started!");
            _product.ShowInfo();
            Console.WriteLine("Yes! The product was calculated successfully!");
        }
    }

    public class ConcreteFactory : AbstractFactory
    {
        private ICalculator _calculator;
        private IProduct _product;

        public override ICalculator Calculator
        {
            get
            {
                return _calculator ?? (_calculator = new ProductCalculator1());
            }
        }

        public override IProduct Product
        {
            get
            {
                return _product ?? (_product = new Product1());
            }
        }
    }
}
