using System;

namespace Unit_Testing
{
    public class Program
    {
        public static decimal balance = 500m;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM.");
            AtmMenu();


        }

        /// <summary>
        /// Method to display ATM menu and get user input for ATM options
        /// </summary>
        public static void AtmMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("|1: Account Balance|; |2: Withdraw|; |3: Deposit|; |4: Exit|");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        AccountBalance();
                        break;
                    case 2:
                        Console.WriteLine($"Your balance is: {AccountBalance()}. How much do you want to withdraw?");
                        int amtToWithdraw = Convert.ToInt32(Console.ReadLine());
                        Withdraw(amtToWithdraw);
                        break;
                    case 3:
                        Console.WriteLine("How much would you like to deposit?");
                        int amtToDeposit = Convert.ToInt32(Console.ReadLine());
                        Deposit(amtToDeposit);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for banking, come again.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Not an option, please try again.");
                        break;
                }
            }
        }

        /// <summary>
        /// Method to show account balance or throw error
        /// </summary>
        /// <returns></returns>
        public static decimal AccountBalance()
        {
            try
            {
                Console.WriteLine($"Your current balance is: ${balance}");
                return balance;
            }
            catch(Exception)
            {
                Console.WriteLine("An error has occured.");
                throw;
            }
        }

        /// <summary>
        /// Method to withdraw money from balance
        /// </summary>
        /// <param name="dollarAmt"></param>
        /// <returns></returns>
        public static decimal Withdraw(decimal dollarAmt)
        {
            try
            {
                if (dollarAmt > balance)
                {
                    Console.WriteLine("Not enough funds");
                    return balance;
                }
                else
                {
                    return balance -= dollarAmt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to deposit money to balance
        /// </summary>
        /// <param name="dollarAmt"></param>
        /// <returns></returns>
        public static decimal Deposit (decimal dollarAmt)
        {
            try
            {
                if (dollarAmt < 0)
                {
                    return balance;
                }
                else
                {
                    return balance += dollarAmt;
                }
            }
            catch(Exception)
            {
                throw;   
            }
        }
    }
}
