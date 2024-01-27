namespace SimplifiedBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clients = new Dictionary<string, Client>()
            {
                {"A", new Client("Anna", "1001A", 1000) },
                {"B", new Client("Bob", "1002B", 1000) },
                {"C", new Client("Cassandra", "1003C", 1000) },
            };


            bool exit = false;
            string typed;
            int moneyToTransfer;

            Client from;
            Client to;

            Console.WriteLine("Hello!");

            /* While the program is not prompted to exit it continues to ask what to do next.
             * You can:
             *  transfer money from one client to another
             *  check client's status
             *  check all client's status
             *  exit
             *  clear console output
             */
            while (!exit)
            {
                Console.WriteLine("Type 1 to transfer money.");
                Console.WriteLine("Type 2 to check client's status.");
                Console.WriteLine("Type 3 to check all client's status.");
                Console.WriteLine("Type 0 to exit.");
                Console.WriteLine("Type - to clear console output.");
                Console.Write("What do you want to do today? ");
                typed = Console.ReadLine();

                if (typed == "0")
                {
                    exit = true;
                }

                else if (typed == "1")
                {
                    Console.Write("Choose from who you want to transfer money: A, B or C? ");
                    clients.TryGetValue(Console.ReadLine().ToUpper(), out from);

                    Console.Write("Now choose to whom you want to transfer money: A, B or C? ");
                    clients.TryGetValue(Console.ReadLine().ToUpper(), out to);

                    Console.Write("How much money do you want to transfer? ");
                    Int32.TryParse(Console.ReadLine(), out moneyToTransfer);

                    Bank.transfer(from, to, moneyToTransfer);
                }

                else if (typed == "2")
                {
                    Console.Write("Choose whose status you want to check: A, B or C? ");
                    clients.TryGetValue(Console.ReadLine().ToUpper(), out from);

                    Bank.getClientInfo(from);
                }

                else if (typed == "3")
                {
                    foreach (Client client in clients.Values)
                    {
                        Bank.getClientInfo(client);
                    }
                }

                else if (typed == "-")
                {
                    Console.Clear();
                }

                else
                {
                    ColorfulMessage.failure("There is no such command yet.");
                }
            }
        }
    }
}
