using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork16
{
    class PriceOfAllItems
    {
        private Dictionary<StoreItem, double> itemsWithPrices = new Dictionary<StoreItem, double>();

        public void AddPriceItemSetAndAddToDictionary(StoreItem storeItm, double cost)
        {
            foreach (var item in itemsWithPrices)
            {
                if(storeItm.GetName() == item.Key.GetName())
                {
                    cost = item.Value;
                }
            }
            itemsWithPrices.Add(storeItm, cost);
        }

        public void PrintAllItemsWithPrices()
        {
            foreach (var item in itemsWithPrices)
            {
                if(item.Key == null)
                {
                    
                }
                else
                    Console.WriteLine($"Item: {item.Key.GetName()} Price: {item.Value}");

            }
        }
    }
}
