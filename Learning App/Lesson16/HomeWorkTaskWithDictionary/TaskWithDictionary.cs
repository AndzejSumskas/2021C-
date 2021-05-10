using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson16.HomeWorkTaskWithDictionary
{
    class TaskWithDictionary
    {
        public void TaskDictionary()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "Tomas" },
                { 2, "Dzeris" },
                { 3, "Povas" },
                { 4, "Lavas" }
            };

            string elementas = myDictionary[2];
            Console.WriteLine("Elementas : {0}",elementas);
            int elemetuSkaicius = myDictionary.Count;
            Console.WriteLine($"Elementu skaicius : {elemetuSkaicius}");

            Dictionary<int, string>.KeyCollection keys = myDictionary.Keys;
            Dictionary<int, string>.ValueCollection values = myDictionary.Values;

            myDictionary.Add(15, "Geraldas");
            myDictionary[10] = "Semionas";

            bool turiRakta = myDictionary.ContainsKey(2);
            Console.WriteLine($"My dictionary contains key 2: {turiRakta}");

            bool turiReiksme = myDictionary.ContainsValue("Lavas");
            Console.WriteLine($"My dictionary contains values Lavas: {turiReiksme}");

            bool turiReiksme2 = myDictionary.ContainsValue("Garas");
            Console.WriteLine($"My dictionary contains values Garas: {turiReiksme2}");

            myDictionary.Remove(6);
            Console.WriteLine($"Elementu skaicius : {elemetuSkaicius}");
            Console.WriteLine("************************************************");
            foreach (KeyValuePair<int, string> keyValuePairs in myDictionary)
            {
                Console.WriteLine(keyValuePairs);
            }
            Console.WriteLine($"Elementu skaicius : {elemetuSkaicius}");

        }
    }
}
