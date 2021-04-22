using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson8.Factory
{
    class warrantySalon
    {
        public string Name;
        public DateTime Laikas;
        private Client client;
        private Parduotuve parduotuve;

        public warrantySalon(string name, DateTime laikas, Client client, Parduotuve parduotuve)
        {
            Name = name;
            Laikas = laikas;
            this.client = client;
            this.parduotuve = parduotuve;
        }

        private void CheckWarranyValid()
        {

        }

        private void DetermineFault()
        {

        }

        public void ConclusionMake()
        {

        }

        public void ClientInfo()
        {
            Console.WriteLine($"Name: {Name} DateTime: {Laikas}, Client: {client}, Parduotuve {parduotuve}");
        }
    }
}
