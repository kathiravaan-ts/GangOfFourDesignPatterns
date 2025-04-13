namespace GangOfFourDesignPatterns.RulesEngine
{
    public interface IDiscountRule
    {
        public decimal GetDiscount(Customer customer);
    }
    public class StudentDiscountRule : IDiscountRule
    {
        public decimal GetDiscount(Customer customer)
        {
            return (customer.Age < 18 ? 25.00m : 0.00m);
        }
    }

    public class SeniorCitizenDiscountRule : IDiscountRule
    {
        public decimal GetDiscount(Customer customer)
        {
            return (customer.Age > 54 ? 20.00m : 0.00m);
        }
    }
}
