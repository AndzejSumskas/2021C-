using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciuSarasas = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                skaiciuSarasas.Add(rnd.Next(1, 100));
            }
            AtspausdintiSarasa(skaiciuSarasas);
            PasalintiDidesniusUz80(skaiciuSarasas);
            Console.WriteLine("Sarasas be skaciu >80:");
            AtspausdintiSarasa(skaiciuSarasas);
            Console.WriteLine("Lyginiai skaiciai:");
            AtspausdintiLyginiusSkaiciusSuForEack(skaiciuSarasas);
            Console.WriteLine();
            SkaiciuKiekisMazesniUzDvidesimt(skaiciuSarasas);
            Console.WriteLine();
            Console.WriteLine();
            BendraInfo(skaiciuSarasas);

        }
        static void BendraInfo(List<int> list)
        {

            Console.WriteLine("BENDRA INFORMACIJA");
            Console.WriteLine("Skaiciu vidurkis: {0}", Convert.ToInt32(list.Average()));
            Console.WriteLine("Didziausias skaicius: {0}", list.Max());
            Console.WriteLine("Maziausias skaicius: {0}", list.Min());
            Console.WriteLine("Skaiciu kiekis :{0}", list.Count);
            
        }
        static int SkaiciuKiekisMazesniUzDvidesimt(List<int> list)
        {
            int counter = 0;
            foreach (var skaicius in list)
            {
                if (skaicius < 20)
                {
                    counter++;
                }
            }
            Console.WriteLine("Skaiciu kiekis mazesniu uz 20 : {0}", counter);
            return counter;
        }

        static void AtspausdintiLyginiusSkaiciusSuForEack(List<int> list)
        {
            List<int> tempList = new List<int>();
            foreach (var skaicius in list)
            {
                if (skaicius % 2 == 0)
                {
                    tempList.Add(skaicius);
                }
            }
            tempList.ForEach(Console.Write);
        }

        static void AtspausdintiSarasa(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + "*");
            }
        }


        static void PasalintiDidesniusUz80(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i]>80)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
