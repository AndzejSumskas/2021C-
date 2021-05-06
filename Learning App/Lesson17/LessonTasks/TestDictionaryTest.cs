using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson17.Dictionary
{
    public class TestDictionaryTest
    {
        public static void FirstTask()
        {
            Dictionary<int, string> manoZodynas = new Dictionary<int, string>();

            manoZodynas.Add(1, "Vienas");
            manoZodynas.Add(2, "Du");
            manoZodynas.Add(3, "Trys");
            manoZodynas.Add(4, "Keturi");
            manoZodynas.Add(5, "Penki");

            manoZodynas[6] = "Sesi";

            Console.WriteLine(manoZodynas.Count);

            manoZodynas.Remove(1);

            Console.WriteLine(manoZodynas.ContainsKey(5));

            Console.WriteLine(manoZodynas.ContainsValue("Du"));

            manoZodynas.Clear();
            Console.WriteLine("Po clear!!");
            Console.WriteLine(manoZodynas.Count);

            manoZodynas.Add(1, "Vienas");
            manoZodynas.Add(2, "Du");
            manoZodynas.Add(3, "Trys");
            manoZodynas.Add(4, "Keturi");
            manoZodynas.Add(5, "Penki");

            string value = "";
            Console.WriteLine(manoZodynas.TryGetValue(2, out value));

            if (manoZodynas.TryGetValue(2, out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }

            Console.WriteLine("keyValuePair");
            foreach (KeyValuePair<int, string> keyValuePair in manoZodynas)
            {
                Console.WriteLine(keyValuePair);
            }


        }
    }
}
