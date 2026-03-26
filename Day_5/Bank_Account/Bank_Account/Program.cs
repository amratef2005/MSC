namespace Bank_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("ACC1", 500000);
            acc.Deposit(2000);        
            acc.Deposit(500);       
            acc.Withdraw(10000);
            acc.SetBalance(-1000);     
            acc.PrintInfo();
            Console.WriteLine(acc.GetBalance());
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
            _accountNumber = accountNumber;
            _balance = 0;
        }

        public BankAccount(string accountNumber, double initialBalance)
        {
            _accountNumber = accountNumber;
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
            Console.WriteLine($"Balance        : {_balance:C}");
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void SetBalance(double balance)
        {
            if (balance >= 0)
                _balance = balance;
            else
                Console.WriteLine("Balance cannot be negative.");
        }
        ~BankAccount()
        {
            Console.WriteLine($"Bank account {_accountNumber} is being closed.");
        }
    }
}
