namespace AbstractFactory 
{
	public class ConcreteFactory : AbstractFactory
    {
        private ICalculator _calculator;
        private ILogger _logger;

        public override ICalculator Calculator
        {
            get
            {
                return _calculator ?? (_calculator = new ConcreteCalculator());
            }
        }

        public override ILogger Logger
        {
            get
            {
                return _logger ?? (_logger = new ConcreteLogger());
            }
        }
    }
}