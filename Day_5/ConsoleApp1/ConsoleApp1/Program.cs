namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("ACC-001", 500);
            acc.Deposit(200);       
            acc.Deposit(50);       
            acc.Withdraw(100);
            acc.SetBalance(-10);     
            acc.PrintInfo();
            Console.WriteLine($"private Balance:{ acc.GetBalance()}");
        }
    }
    public class BankAccount
    {
        private string _accountNumber;
        private double _balance;

        public string AccountNumber => _accountNumber;

        public double Balance
        {
            get => _balance;
            private set => _balance = value;
        }

        public BankAccount(string accountNumber)
        {
            accountNumber = accountNumber;
            _balance = 0;
        }

        public BankAccount(string accountNumber, double initialBalance)
        {
            accountNumber = accountNumber;
            _balance = initialBalance >= 0 ? initialBalance : 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                _balance += amount;
            else
                Console.WriteLine("Deposit amount must be positive.");
        }

        public void Deposit(int amount)
        {
            Deposit((double)amount);
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                Console.WriteLine("Withdrawal amount must be positive.");
            else if (amount > _balance)
                Console.WriteLine("Insufficient funds.");
            else
                _balance -= amount;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Account Number : {_accountNumber}");
            Console.WriteLine($"Balance        : {_balance}");
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void SetBalance(double balance)
        {
            if (balance >= 0)
                balance = balance;
            else
                Console.WriteLine("Balance cannot be negative.");
        }
        ~BankAccount() { }
    }
}
