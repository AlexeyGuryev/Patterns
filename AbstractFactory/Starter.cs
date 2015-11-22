using System;
using Patterns;

namespace AbstractFactory
{
    public class Starter : IStarter
    {
        public string Name
        {
            get
            {
                return "AbstractFactory";
            }
        }

        public void Run()
        {
            AbstractFactory factory = new ConcreteFactory();
            factory.Calculator.Calculate();
            factory.Logger.LogInfo("Logger prints it");
        }
    }
}