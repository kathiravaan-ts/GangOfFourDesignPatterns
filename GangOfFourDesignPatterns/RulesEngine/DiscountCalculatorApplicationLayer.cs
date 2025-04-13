namespace GangOfFourDesignPatterns.RulesEngine
{
    public class DiscountCalculatorApplicationLayer
    {
        private readonly Customer customer;
        public DiscountCalculatorApplicationLayer() 
        {
            customer = new Customer() { ID = Guid.NewGuid().ToString(), Name="kathiravaan.ts", Age=33, JoinedDate= DateTime.Now };
        }

        public void DiscountCalculator()
        {
            var _ruleType = typeof(IDiscountRule);
            var _rules = GetType().Assembly.GetTypes()
                        .Where(s => _ruleType.IsAssignableFrom(s) && !s.IsInterface)
                        .Select(s => Activator.CreateInstance(s) as IDiscountRule)
                        ;

            IDiscountEngine _engine = new DiscountEngine(_rules);
            var _Rst = _engine.CalculateDiscountPercentage(customer);

        }


    }
}
