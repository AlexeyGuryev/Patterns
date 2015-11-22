using System;

namespace FactoryMethod
{  
    public abstract class ProductManager
    {
        public void Calculate() { }

        /// <summary>
        /// Factory method Create
        /// ProductManager do not know about concrete products
        /// </summary>
        /// <returns></returns>
        public abstract Product Create();
    }

    public class CreditManager : ProductManager
    {
        public override Product Create()
        {
            return new Credit();
        }
    }

    public class DepositManager : ProductManager
    {
        public override Product Create()
        {
            return new Deposit();
        }
    }

    public abstract class Product
    {
        public string Name { get; set; }
        public abstract void Print();
    }

    public class Credit : Product
    {
        public override void Print()
        {
            Console.WriteLine("It's a credit product");
        }
    }

    public class Deposit : Product
    {
        public override void Print()
        {
            Console.WriteLine("It's a deposit product");
        }
    }

    
}
