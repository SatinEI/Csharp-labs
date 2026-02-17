namespace ConsoleApp1
{
    public abstract class Account
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive");
            Balance += amount;
        }
        public abstract void Withdraw(decimal amount);
        public virtual decimal CalculateInterest()
        {
            return Balance * 0.01m;
        }
        //Виртуальный метод для проверки возможности снятия
        public virtual bool CanWithdraw(decimal amount)
        {
            return amount > 0 && amount <= Balance;
        }
    }

    public class SavingsAccount : Account
    {
        public decimal MinimumBalance { get; } = 100m;

        public override void Withdraw(decimal amount)
        {
            if (!CanWithdraw(amount))
                throw new InvalidOperationException("Cannot withdraw this amount");
            Balance -= amount;
        }

        public override bool CanWithdraw(decimal amount)
        {
            return base.CanWithdraw(amount) && (Balance - amount) >= MinimumBalance;
        }
    }

    public class CheckingAccount : Account
    {
        public decimal OverdraftLimit { get; } = 500m;

        public override void Withdraw(decimal amount)
        {
            if (!CanWithdraw(amount))
                throw new InvalidOperationException("Cannot withdraw this amount");
            Balance -= amount;
        }

        public override bool CanWithdraw(decimal amount)
        {
            return amount > 0 && (Balance - amount) >= -OverdraftLimit;
        }
    }

    public class FixedDepositAccount : Account
    {
        public DateTime MaturityDate { get; }

        public FixedDepositAccount(DateTime maturityDate)
        {
            MaturityDate = maturityDate;
        }

        public override void Withdraw(decimal amount)
        {
            if (!CanWithdraw(amount))
                throw new InvalidOperationException("Cannot withdraw before maturity date");

            Balance -= amount;
        }

        public override bool CanWithdraw(decimal amount)
        {
            if (DateTime.Now < MaturityDate)
                return false;

            return base.CanWithdraw(amount);
        }

        public override decimal CalculateInterest()
        {
            return Balance * 0.05m;
        }
    }

    public class Bank
    {
        public void ProcessWithdrawal(Account account, decimal amount)
        {
            if (!account.CanWithdraw(amount))
            {
                Console.WriteLine($"Cannot withdraw {amount}: Account cannot process this withdrawal");
                return;
            }

            try
            {
                account.Withdraw(amount);
                Console.WriteLine($"Successfully withdrew {amount}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Withdrawal failed: {ex.Message}");
            }
        }

        public void Transfer(Account from, Account to, decimal amount)
        {
            if (!from.CanWithdraw(amount))
            {
                Console.WriteLine($"Transfer failed: Source account cannot withdraw {amount}");
                return;
            }

            from.Withdraw(amount);
            to.Deposit(amount);
            Console.WriteLine($"Successfully transferred {amount}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            var bank = new Bank();
            var savings = new SavingsAccount();
            savings.Deposit(1000);
            var fixedDeposit = new FixedDepositAccount(DateTime.Now.AddMonths(6));
            fixedDeposit.Deposit(5000);
            Console.WriteLine($"Can withdraw from savings: {savings.CanWithdraw(200)}"); // true
            Console.WriteLine($"Can withdraw from fixed deposit: {fixedDeposit.CanWithdraw(500)}"); // false
            bank.Transfer(savings, fixedDeposit, 200); // Успешно
            bank.Transfer(fixedDeposit, savings, 500); // Сообщит о невозможности
        }
    }
}