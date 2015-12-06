namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract ILogger Logger { get; }
        public abstract ICalculator Calculator { get; }
    }    
}
