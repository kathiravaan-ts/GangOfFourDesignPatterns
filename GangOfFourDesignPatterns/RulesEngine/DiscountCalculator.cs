namespace GangOfFourDesignPatterns.RulesEngine
{
    public interface IDiscountEngine
    {
        decimal CalculateDiscountPercentage(Customer customer);

    }
    public class DiscountEngine : IDiscountEngine
    {
        private readonly List<IDiscountRule> _discountRules = null!;
        public DiscountEngine(IEnumerable<IDiscountRule> discountRules)
        {
            _discountRules.AddRange(discountRules);
        }
        public decimal CalculateDiscountPercentage(Customer customer)
        {
            List<decimal> rst = new List<decimal>();

            foreach(var rule in _discountRules)
            {
                rst.Add(rule.GetDiscount(customer));
            }
            return rst.Max();
        }
    }
}