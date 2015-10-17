using System;

namespace GoF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory method***");
            new FactoryMethodStarter().Run();

            Console.WriteLine("***Abstract factory***");
            new AbstractFactoryStarter().Run();

            Console.ReadKey();
        }
    }
}
