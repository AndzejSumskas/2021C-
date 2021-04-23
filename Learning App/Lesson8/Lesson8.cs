using Learning_App.Lesson8.Factory;
using Learning_App.Lesson8.Factory.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Parduotuve parduotuve1 = new Parduotuve("Topo vaikis", "Elektronine prekyba");

            Book myBook = new Book("Budejimo pabaiga", new Author("S. Kingas"), new DateTime(2018, 06, 30));

            Client client1 = new Client("Tomas", "Tomenas", 6464686, parduotuve1);

            Client client2 = new Client("Gedrius", "Gedraitis", 65855626, new Parduotuve("Aukso pasaulis", "Papuosalai"));

            client2.choseBestGoods();

            warrantySalon salon1 = new warrantySalon("Batu taisykla", new DateTime(2020, 12, 12), client1, new Parduotuve ("Batu pasaulis", "Avalynes parduotuve"));

            Console.WriteLine(client1.Name + " " + client1.SecondName);   //Per taska matomi tik public reiksmes


            Console.WriteLine(parduotuve1.ParduotuvesPavadinimas);

            
        }
    }
}
