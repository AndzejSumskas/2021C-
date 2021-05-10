using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork16
{
    class HomeWork16
    {
        static void Main()
        {
            Store store = new Store();

            Truck truck = new Truck();

            string prekiuSarasas = File.ReadAllText(@"C:\Users\Andzej\Desktop\C#\01Paskaita\LearningAppGit\Learning App\HomeWork16\StackStoreItems.txt");

            Stack<string> storeItems = new Stack<string>();

            
            
             string[] arrayListShopItems =  prekiuSarasas.Split("\n").ToArray();

            

            foreach (var item in arrayListShopItems)
            {
                storeItems.Push(item);
            }

            truck.LoadStoreItem(new StoreItem("Pomidoriukai"));
            truck.LoadStoreItem(new StoreItem("Grybukai"));
            truck.LoadStoreItem(new StoreItem("Zuvis"));
            truck.LoadStoreItem(new StoreItem("Bananai"));
            truck.LoadStoreItem(new StoreItem("Alyvuoges"));
            truck.LoadStoreItem(new StoreItem("Zemoges"));
            truck.LoadStoreItem(new StoreItem("Slyvos"));


            truck.PrintItems();

            store.LoadStoreItems(truck.GetItems());
            store.LoadStoreItems(truck.GetItems());
            store.LoadStoreItems(truck.GetItems());
            Console.WriteLine("****************");
            truck.PrintItems();

            store.PrintInventory();




        }

    }
}
