using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewArnoldUserAccounts
{
    class Program
    {

        static List<Account> accounts = new List<Account>();

        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Welcome to Arnold's Money Factory:");
                Console.WriteLine("1. Create Account; 2. Show Accounts; 3. Log in; 4. Quit");

                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    CreateAccount();
                }
                else if(choice == 2)
                {
                    ShowAccounts();
                }
                else if (choice == 3)
                {
                    LogIn();
                }
                else if(choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                //Account newAccount = new Account

            }



        }

        static void CreateAccount()
        {
           
            Console.WriteLine("First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Initial money: ");
            double initMoney = double.Parse(Console.ReadLine());
            Account newAccount = new Account(firstName, lastName, initMoney);
            accounts.Add(newAccount);
        }

        static void ShowAccounts()
        {
            Console.WriteLine("Here are the accounts, bitch: ");

            for (int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine(accounts[i]);
            }

        }

        static void LogIn()
        {
            bool loggedIn = true;

            while(loggedIn == true)
            {
                Console.WriteLine("Hooray! you're logged in!!!!");
                Console.WriteLine("What would you like to do?");
                string result = Console.ReadLine();
                if(result == "log out")
                {
                    loggedIn = false;
                }
            }

        }
    }
}
