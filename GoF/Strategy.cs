using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF
{
    public class StrategyRunner : IStarter
    {
        public void Run()
        {
            var firstExample = new CalcData
            {
                A = 3,
                B = 2
            };

            var calculator = new Calculator(firstExample);
            calculator.CalcStrategy = new StrategyAddition();

            Console.WriteLine("{0} with {1} = {2}", firstExample.A, firstExample.B, calculator.Calc());

            calculator.CalcStrategy = new StrategySubtraction();
            Console.WriteLine("{0} with {1} = {2}", firstExample.A, firstExample.B, calculator.Calc());

            Console.WriteLine("{0} with {1} = {2}", firstExample.A, firstExample.B, calculator.Calc(c => c.A * c.B));
        }
    }

    public interface ICalulationStrategy
    {
        int CalcTwoNumbers(int a, int b);
    }

    public class Calculator
    {
        private CalcData calcData;
        public ICalulationStrategy CalcStrategy { get; set; }

        public Calculator(CalcData calcData)
        {
            this.calcData = calcData;
        }

        public int Calc()
        {
            if (CalcStrategy == null)
            {
                throw new ArgumentNullException("CalcStrategy need to be set firstly!");
            }

            return CalcStrategy.CalcTwoNumbers(calcData.A, calcData.B);
        }

        public int Calc(Func<CalcData, int> twoNumbersCalculator)
        {
            return twoNumbersCalculator(calcData);
        }
    }

    public class CalcData
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    public class StrategyAddition : ICalulationStrategy
    {
        public int CalcTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }

    public class StrategySubtraction : ICalulationStrategy
    {
        public int CalcTwoNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
