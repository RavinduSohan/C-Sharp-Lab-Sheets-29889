namespace Lab_Sheet_1_Question_7
{
    internal class Program
    {
        static float balance = 1000; // Initial balance

        static void Main(string[] args)
        {
            int choice;
            do
            {
                DisplayMenu();
                Console.Write("Enter your choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 4);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("ATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${balance}");
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: ");
            float amount;
            if (float.TryParse(Console.ReadLine(), out amount) && amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit successful. Your new balance is: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Deposit failed.");
            }
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: ");
            float amount;
            if (float.TryParse(Console.ReadLine(), out amount) && amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance}");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Withdrawal failed.");
            }
        }
    }
}
