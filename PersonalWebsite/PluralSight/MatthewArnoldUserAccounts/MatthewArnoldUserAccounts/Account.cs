using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewArnoldUserAccounts
{
    public class Account
    {

        static int numOfAccounts = 0;
        // Properties
        string firstName;
        public string FirstName { get { return firstName; } set { firstName = value; } }

        string lastName;
        public string LastName { get { return lastName; } set { lastName = value; } }

        double money;
        public double Money { get { return money; } set { money = value; } }
       
        // Constructor: Initializes properties
        public Account(string firstName, string lastName, double money)
        {
            numOfAccounts++;
            this.firstName = firstName;
            this.lastName = lastName;
            this.money = money;
        }

        // Methods: manipulates properties
        public void Deposit(double money)
        {
            this.money += money;
        }
        public void Withdraw(double money)
        {
            this.money -= money;
        }

        public override string ToString()
        {
            return $"{firstName}, {lastName}; {money}";
        }

    }
}
