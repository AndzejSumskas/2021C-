using System.Collections.Generic;

namespace Learning_App.HomeWork16
{
    class StoreItem : Store
    {
        string name { get; set; }

        public Stack<StoreItem> storeItems = new Stack<StoreItem>();

        public StoreItem(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}