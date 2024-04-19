namespace Lab_Sheet_2_Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456789", 1000.0f);

            Console.WriteLine("Initial Balance: " + account.Balance);

            Console.Write("Enter the amount to deposit: ");
            float depositAmount = float.Parse(Console.ReadLine());

            account.Deposit(depositAmount);

            Console.WriteLine("Updated Balance: " + account.Balance);
        }
    }

    class BankAccount
    {
        public string AccountNumber { get; set; }
        public float Balance { get; set; }

        public BankAccount(string accountNumber, float initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(float amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }
    }
}
