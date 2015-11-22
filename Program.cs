using System;
using System.Collections.Generic;

namespace Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var patterns = new List<IStarter>
            {
                new AbstractFactory.Starter(),
                new FactoryMethod.Starter()
            };
            
            foreach(var pattern in patterns)
            {
                Console.WriteLine("\n<<< Pattern: {0} Start >>>\n", pattern.Name);
                pattern.Run();
                Console.WriteLine("\n<<< Pattern: {0} End >>>", pattern.Name);               
            }
            
            Console.Read();
        }
    }
}
