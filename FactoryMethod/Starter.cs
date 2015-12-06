using Patterns;

namespace FactoryMethod
{
	public class Starter : IStarter
    {
        public string Name
        {
            get
            {
                return "FactoryMethod";
            }
        }

        public void Run()
        {
            Product credit = new CreditManager().Create();
            credit.Print();

            Product deposit = new DepositManager().Create();
            deposit.Print();
        }
    }
}