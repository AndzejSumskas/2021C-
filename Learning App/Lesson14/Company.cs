using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson14
{
    class Company : Human, IPrintMe
    {
        private Human _boss;
        private readonly string _name;

        private List<Client> clientList = new List<Client>();

        private List<Worker> workerList = new List<Worker>();      

        public Company(Human boss, string name) : base(name)
        {
            _boss = boss;
            _name = name;
        }

        public Dog OfficePet { get; set; }

        public void AddClient(Client client)
        {
            clientList.Add(client);
        }

        public void FireWorker(Worker worker)
        {
            workerList.Remove(worker);
        }

        public void HireWorker(Worker worker)
        {
            workerList.Add(worker);
        }

        public void PrintAllClients()
        {
            Console.WriteLine("Clients:");
            foreach (var client in clientList)
            {
                client.PrintInfo();
            }
        }

        public void PrintAllWorkers()
        {
            Console.WriteLine("Workers:");
            foreach (var worker in workerList)
            {
                worker.PrintInfo();
            }
        }

        public void PrintInfo()
        {
            PrintAllClients();
            PrintAllWorkers();
            OfficePet.PrintInfo();
        }    
    }
}
