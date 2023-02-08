namespace Components
{
    public interface ISupplyNumber
    {
        int GetNumber();
    }

    public class FactorialCalculator
    {
        private readonly ISupplyNumber _numberService;

        public FactorialCalculator(ISupplyNumber numberService)
        {
            _numberService = numberService;
        }

        public long CalculateRecursively()
        {
            var number = _numberService.GetNumber();
            return recursiveCalculation(number);
        }

        private long recursiveCalculation(int number)
        {
            if (number < 1)
            {
                return 1;
            }

            return number * recursiveCalculation(number - 1);
        }

        public long CalculateWithLoop()
        {
            var number = _numberService.GetNumber();
            var factorialResult = 1L;

            while (number != 1)
            {
                factorialResult *= number;
                number--;
            }
            return factorialResult;
        }

    }
}