namespace ConsoleApp1
{
    // Базовый класс для скидок
    public abstract class Discount
    {
        public abstract decimal CalculateDiscount(decimal orderAmount);
        public abstract string CustomerType { get; }
    }
    public class RegularDiscount : Discount
    {
        public override string CustomerType => "Regular";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.05m;
    }
    public class PremiumDiscount : Discount
    {
        public override string CustomerType => "Premium";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.10m;
    }
    public class VIPDiscount : Discount
    {
        public override string CustomerType => "VIP";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.15m;
    }
    public class StudentDiscount : Discount
    {
        public override string CustomerType => "Student";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.08m;
    }
    public class SeniorDiscount : Discount
    {
        public override string CustomerType => "Senior";
        public override decimal CalculateDiscount(decimal orderAmount) => orderAmount * 0.07m;
    }







    // Базовый класс для доставки
    public abstract class Shipping
    {
        public abstract decimal CalculateShippingCost(decimal weight, string destination);
        public abstract string ShippingMethod { get; }
    }
    public class StandardShipping : Shipping
    {
        public override string ShippingMethod => "Standard";
        public override decimal CalculateShippingCost(decimal weight, string destination)
            => 5.00m + (weight * 0.5m);
    }

    public class ExpressShipping : Shipping
    {
        public override string ShippingMethod => "Express";
        public override decimal CalculateShippingCost(decimal weight, string destination)
            => 15.00m + (weight * 1.0m);
    }

    public class OvernightShipping : Shipping
    {
        public override string ShippingMethod => "Overnight";
        public override decimal CalculateShippingCost(decimal weight, string destination)
            => 25.00m + (weight * 2.0m);
    }

    public class InternationalShipping : Shipping
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