using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedBank
{
    /// <summary>
    /// The client of our bank
    /// </summary>
    internal class Client
    {
        private readonly string name;
        private string account;
        private int balance;

        /// <summary>
        /// Our client
        /// </summary>
        /// <param name="name">Client's name</param>
        /// <param name="account">His account</param>
        /// <param name="money">And money he has</param>
        public Client(string name, string account, int money)
        {
            this.name = name;
            this.account = account;
            this.balance = money;
        }

        /// <summary>
        /// Client's name getter
        /// </summary>
        /// <returns>Client's name</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Client's account getter
        /// </summary>
        /// <returns>Client's account</returns>
        public string getAccount()
        {
            return account;
        }

        /// <summary>
        /// Client's money getter
        /// </summary>
        /// <returns>Client's money</returns>
        public int getBalance()
        {
            return balance;
        }

        /// <summary>
        /// Method to add money on client's account
        /// </summary>
        /// <param name="money">Amount of money to be added</param>
        /// <returns>Final amount of money after transaction</returns>
        public int addMoney(int money)
        {
            return this.balance += money;
        }

        /// <summary>
        /// Method to reduce money on client's account
        /// </summary>
        /// <param name="money">Amount of money to be reduced</param>
        /// <returns>Final amount of money after transaction</returns>
        public int reduceMoney(int money)
        {
            if (this.balance < money)
            {
                ColorfulMessage.failure("Insufficient funds for a " + money + "$ transfer; current balance is " + this.balance + "$!");
                return -1;
            }
            return this.balance -= money;
        }
    }
}
