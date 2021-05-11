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
            //Parduotuves sukurimas
            Store store = new Store();

            //Sunkvezimio sukurimas     
            Truck truck = new Truck();

            //store claseje idedam storeItem i stack      Stack<string> storeItems = new Stack<string>();

            store.AddStoreItemToStack(new StoreItem ("Lemon"));


            //Perskaitome prekiu sarasa is failo
            string prekiuSarasas = File.ReadAllText(@"C:\Users\Andzej\Desktop\C#\01Paskaita\LearningAppGit\Learning App\HomeWork16\StackStoreItems.txt");
                
            //Sukuriame masyva kur irasome perkes is failo
            string[] arrayListShopItems =  prekiuSarasas.Split("\n").ToArray(); //Console.WriteLine($"*****\n{arrayListShopItems[2]}\n#############");

            //Paimam visus storeItems is failo ir issaugome i store HashSet
            foreach (var item in arrayListShopItems)
            {
                store.storeItemsHashSet.Add(new StoreItem(item));
            }
            
            //Prikrauname truck naujai storeItems
            truck.LoadStoreItem(new StoreItem("Pomidoriukai"));
            truck.LoadStoreItem(new StoreItem("Grybukai"));
            truck.LoadStoreItem(new StoreItem("Zuvis"));
            truck.LoadStoreItem(new StoreItem("Bananai"));
            truck.LoadStoreItem(new StoreItem("Alyvuoges"));
            truck.LoadStoreItem(new StoreItem("Zemoges"));
            truck.LoadStoreItem(new StoreItem("Slyvos"));

            //Atspausdiname truck inventory
            truck.PrintItems();
            //Atsapusdiname store inventory
            store.PrintInventory();

            //Is sunkvezimio paimame pirmaja preke ir idedame i store HashSet(preke pasalinama is sunkvezimio)
            store.LoadStoreItems(truck.GetItems());
            store.LoadStoreItems(truck.GetItems());
            store.LoadStoreItems(truck.GetItems());
            store.LoadStoreItems(truck.GetItems());

           //Atspausdiname truck inventory
            truck.PrintItems();
            //Atsapusdiname store inventory
            store.PrintInventory();

            PriceOfAllItems priceOfAllItems = new PriceOfAllItems();

            // priceOfAllItems.AddPriceItemSetAndAddToDictionary

            double price = 2.36;

            foreach (var item in store.GetAllStoreItems())
            {
                priceOfAllItems.AddPriceItemSetAndAddToDictionary(item, price);
                price+=0.26;
            }
            foreach (var item in truck.GetAllTruckItems())
            {
                priceOfAllItems.AddPriceItemSetAndAddToDictionary(item, price);
            }

            priceOfAllItems.PrintAllItemsWithPrices();

        }

    }
}
