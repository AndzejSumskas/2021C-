using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork16
{
    class Truck
    {
        Store store = new Store();

        private HashSet<StoreItem> truckItems = new HashSet<StoreItem>();

        public void LoadStoreItem(StoreItem storeItem)
        {
            truckItems.Add(storeItem);
        }

        internal void PrintItems()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Truck inventory:");
            foreach (var item in truckItems)
            {
                Console.WriteLine(item.GetName());
            }
            Console.WriteLine("*****************************");
        }

        public StoreItem GetItems()
        {
            StoreItem stI=  truckItems.First();
            truckItems.Remove(truckItems.First());
            return stI;   
        }

        public HashSet<StoreItem> GetAllTruckItems()

        {
            return truckItems;
        }



    }
}
