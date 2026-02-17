namespace ConsoleApp1
{
    // Базовый класс для скидок
    public abstract class DiscountStrategy
    {
        public abstract decimal CalculateDiscount(decimal orderAmount);
        public abstract string CustomerType { get; }
    }
    public class RegularDiscount : DiscountStrategy
    {
        public override string CustomerType => "Regular";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.05m;
    }
    public class PremiumDiscount : DiscountStrategy
    {
        public override string CustomerType => "Premium";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.10m;
    }
    public class VIPDiscount : DiscountStrategy
    {
        public override string CustomerType => "VIP";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.15m;
    }
    public class StudentDiscount : DiscountStrategy
    {
        public override string CustomerType => "Student";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.08m;
    }
    public class SeniorDiscount : DiscountStrategy
    {
        public override string CustomerType => "Senior";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.07m;
    }







    // Базовый класс для доставки
    public abstract class ShippingStrategy
    {
        public abstract decimal CalculateShippingCost(decimal weight, string destination);
        public abstract string ShippingMethod { get; }
    }
    public class StandardShipping : ShippingStrategy
    {
        public override string ShippingMethod => "Standard";
        public override decimal CalculateShippingCost(decimal weight, string destination)
            => 5.00m + (weight * 0.5m);
    }

    public class ExpressShipping : ShippingStrategy
    {
        public override string ShippingMethod => "Express";
        public override decimal CalculateShippingCost(decimal weight, string destination)
            => 15.00m + (weight * 1.0m);
    }

    public class OvernightShipping : ShippingStrategy
    {
        public override string ShippingMethod => "Overnight";
        public override decimal CalculateShippingCost(decimal weight, string destination)
            => 25.00m + (weight * 2.0m);
    }

    public class InternationalShipping : ShippingStrategy
    {
        public override string ShippingMethod => "International";
        public override decimal CalculateShippingCost(decimal weight, string destination)
        {
            return destination switch
            {
                "USA" => 30.00m,
                "Europe" => 35.00m,
                "Asia" => 40.00m,
                _ => 50.00m
            };
        }
    }
}