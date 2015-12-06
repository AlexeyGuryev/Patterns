using System;

namespace AbstractFactory
{
	public class ConcreteCalculator : ICalculator
    {
        public void Calculate()
        {
            Console.WriteLine("Caution! The product calculation started!");
            Console.WriteLine("Yes! The product was calculated successfully!");
        }
    }
}