using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork16
{
    class Store
    {
        public  HashSet<StoreItem> storeItemsHashSet = new HashSet<StoreItem>();

        public Stack<StoreItem> storeItems = new Stack<StoreItem>();

        internal void LoadStoreItems(StoreItem storeItem)
        {
            storeItemsHashSet.Add(storeItem);
        }

        public void PrintInventory()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Store inventory:");
            foreach (var item in storeItemsHashSet)
            {
                Console.WriteLine(item.GetName());
            }
            Console.WriteLine("*****************************");
        }

        public HashSet<StoreItem> GetAllStoreItems()
        {
            return storeItemsHashSet;
        }

        public void AddStoreItemToStack(StoreItem item)
        {
            storeItems.Push(item);
        }
    }
}
