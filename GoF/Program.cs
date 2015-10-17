using System;
using System.Collections.Generic;

namespace GoF
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, IStarter>
            {
                { "Factory method", new FactoryMethodStarter() },
                { "Abstract factory", new AbstractFactoryStarter() },
                { "Strategy", new StrategyRunner() }
            };

            foreach (var pattern in dictionary.Keys)
            {
                Console.WriteLine("***{0}***", pattern);
                dictionary[pattern].Run();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
