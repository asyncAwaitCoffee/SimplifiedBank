using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedBank
{
    /// <summary>
    /// Bank class responsible for transfering money and drawing client's info.
    /// </summary>
    internal class Bank
    {
        /// <summary>
        /// Transfers money from client A to client B
        /// </summary>
        /// <param name="from">Client A</param>
        /// <param name="to">Client B</param>
        /// <param name="money">Amount of money</param>
        public static void transfer(Client from, Client to, int money)
        {
            if (from == null || to == null)
            {
                ColorfulMessage.failure("No client was provided!");
                return;
            }
            if (from == to)
            {
                ColorfulMessage.failure("You are trying to transfer money within the same client!");
                return;
            }

            if (money <= 0)
            {
                ColorfulMessage.failure("Amount should be at least 1$.");
                return;
            }

            if (from.reduceMoney(money) > 0)
            {
                to.addMoney(money);
                ColorfulMessage.success("Successfuly transfered " + money + "$ from " + from.getName() + " to " + to.getName() + "!");
            }            
        }

        /// <summary>
        /// Draws client's info
        /// </summary>
        /// <param name="client">Client</param>
        public static void getClientInfo(Client client)
        {
            if (client == null)
            {
                ColorfulMessage.failure("No client was provided!");
                return;
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine(" Name: " + client.getName());
            Console.WriteLine(" Account: " + client.getAccount());
            Console.WriteLine(" Balance: " + client.getBalance());
            Console.WriteLine("---------------------------");
        }
    }
}
