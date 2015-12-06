using System;

namespace AbstractFactory
{
    public class ConcreteLogger : ILogger
    {
        void ILogger.LogInfo(string name)
        {
            Console.WriteLine("{0} - {1}", DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss"), name);
        }
    }	
}