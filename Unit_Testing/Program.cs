using System;

namespace Unit_Testing
{
    public class Program
    {
        public static decimal balance = 500;

        public static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to the ATM.");


            //setting up menu for atm selections and collecting user input
            //based on selection, method for that action invoked
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1: Account Balance");
                Console.WriteLine("2: Withdraw");
                Console.WriteLine("3: Deposit");
                Console.WriteLine("4: Exit");
                int input = Convert.ToInt32(Console.ReadLine());

                switch(input)
                {
                    case 1:
                        AccountBalance();
                        break;
                    case 2:
                        Console.WriteLine($"Your balance is: {AccountBalance}.");
                        //Withdraw();
                        break;



                }
            }

        }
    }
}
