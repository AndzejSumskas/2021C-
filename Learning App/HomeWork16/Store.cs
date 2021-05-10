using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork16
{
    class Store
    {
        private  HashSet<StoreItem> storeItems = new HashSet<StoreItem>();

        internal void LoadStoreItems(StoreItem storeItem)
        {
            storeItems.Add(storeItem);
        }

        public void PrintInventory()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Store inventory:");
            foreach (var item in storeItems)
            {
                Console.WriteLine(item.GetName());
            }
        }
    }
}
