using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork4
{
    class Program
    {
        static void Main()
        {
            //Fibonačio skaičių seka

            //int sk1 = 0;
            //int sk2 = 1;
            //int temp;
            //int FSkaiciuKiekis=Convert.ToInt32(Console.ReadLine());

            //if (FSkaiciuKiekis >= 1) 
            //{
            //    Console.Write("0 ");
            //}
            //if (FSkaiciuKiekis >= 2) 
            //{
            //    Console.Write("1 ");
            //}
            //if (FSkaiciuKiekis > 2) 
            //{
            //    for (int i = 0; i < FSkaiciuKiekis - 2; i++)
            //    {
            //        temp = sk1 + sk2;
            //        sk1 = sk2;
            //        sk2 = temp;
            //        Console.Write(temp + " ");
            //    }
            //}

            //Papildoma užduotis - while

            int skaicius = new Random().Next(0, 100);           
            int spejimuSkaicius = 0;                       
            bool arAtspeta = true;
            while(arAtspeta)
            {
                Console.WriteLine("Atspekite skaiciu nuo 0 iki 100.");
                int spejimas = Convert.ToInt32(Console.ReadLine());
                spejimuSkaicius++;
                if(spejimas>skaicius)
                {
                    Console.WriteLine("Mazesnis!");
                }
                else if(spejimas<skaicius)
                {
                    Console.WriteLine("Didesnis!");
                }
                else
                {
                    Console.WriteLine("Atspejote is {0} karto!", spejimuSkaicius);
                    arAtspeta = false;
                }
            }
        }
    }
}
