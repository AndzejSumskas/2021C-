using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> skaiciai123 = new List<int>() { 0, 1, 2, 3, 4, 5, 5, 7, 5, 9 };
            //List<int> skaiciai = new List<int>();
            //skaiciai.Add(5);
            //skaiciai.Add(7);
            //skaiciai.Add(8);
            //skaiciai.Add(15);
            //skaiciai.Add(25);
            //skaiciai.Add(65);

            //skaiciai.Insert(6, 69988);

            //foreach (var item in skaiciai)
            //{
            //    Console.Write(item + "*");
            //}
            //Console.WriteLine();
            //Console.WriteLine(skaiciai.Count);

            //skaiciai.ForEach(Console.Write);

            //List<int> kitiSkaiciai = new List<int>();

            //int sk = 12;
            //for (int i = 0; i < 120; i++)
            //{
            //    kitiSkaiciai.Add(sk++);
            //}
            //skaiciai.AddRange(kitiSkaiciai);

            //foreach (var item in skaiciai)
            //{
            //    Console.Write(item + "*");
            //}

            //skaiciai.InsertRange(2, skaiciai123);
            //Console.WriteLine("************************");
            //foreach (var item in skaiciai)
            //{
            //    Console.Write(item + "*");
            //}

            //skaiciai.RemoveRange(10, 120);                 //*
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var item in skaiciai)
            //{
            //    Console.Write(item + "*");
            //}

            //int number = skaiciai.Last();

            //skaiciai.Remove(5);                          //*
            //skaiciai.RemoveAt(6);                       //*

            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (var item in skaiciai)
            //{
            //    Console.Write(item + "*");
            //}

            //skaiciai.RemoveAll(FindEven);                    //*

            //Console.WriteLine();
            //Console.WriteLine("*********************");

            //foreach (var item in skaiciai)
            //{
            //    Console.Write(item + "*");
            //}
            //skaiciai.Clear();                         //*

            //Console.WriteLine("\nSkaiciai.Count");
            //Console.WriteLine(skaiciai.Count);
            //List<int> skaiciaiIki10 = new List<int>() { 0, 1, 2, 3, 4, 5, 5, 7, 5, 9 };

            //Console.WriteLine();
            //Console.WriteLine("Count");
            //Console.WriteLine(skaiciaiIki10.Count());
            //Console.WriteLine("Contains");
            //Console.WriteLine(skaiciaiIki10.Contains(5));
            //Console.WriteLine("InexOf");
            //Console.WriteLine(skaiciaiIki10.IndexOf(9));
            //Console.WriteLine("Find Even");
            //Console.WriteLine(skaiciaiIki10.Find(FindEven));
            //Console.WriteLine(skaiciaiIki10.Find(FindOdd));
            //Console.WriteLine("Exists");
            //Console.WriteLine(skaiciaiIki10.Exists(FindEven));
            //Console.WriteLine("TrueForAll");
            //Console.WriteLine(skaiciaiIki10.TrueForAll(FindEven));

            //Console.WriteLine(skaiciaiIki10.Sum());

            //Console.WriteLine(skaiciaiIki10.Average());

        }

        private static bool FindEven(int element)
        {
            return element % 2 == 0;
        }

        private static bool FindOdd(int element)
        {
            return element % 2 != 0;
        }
    }
}
