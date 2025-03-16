namespace C_Basics.Oop.Encapsulation
{
    public class BankAccount
    {
        private double balance;
        private string accountNumber;

        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}, New Balance: {balance}");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}, New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount");
            }
        }
    }

}
