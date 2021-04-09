using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Labas....");
            //SayHello();
            //SaySomething();
            //Console.WriteLine("...viso gero!");
            //DoSum("message", 6, 8);
            //DoSum("zinute", 5, 6, 7);

            Exercise1();

            Exercise2();

            Exercise3();

        }

        static void Exercise3()
        {
            double zmMasInd = Exercise2();

            if (zmMasInd < 15)
            {
                Console.WriteLine("Badaujantis zmogus");
            }
            else if (zmMasInd < 18.5)
            {
                Console.WriteLine("Liesas zmogus");
            }
            else if (zmMasInd < 25) 
            {
                Console.WriteLine("Normalauas svorio zmogus");
            }
            else if (zmMasInd < 30)
            {
                Console.WriteLine("Truntis virssvorio zmogus");
            }
            else if (zmMasInd < 40)
            {
                Console.WriteLine("nutukes zmogus");
            }
            else
                Console.WriteLine("Ligotai nutukes zmogus");

        }
        static double Exercise2()
        {
            Console.WriteLine("Ugis, metrais.");
            double ugis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Svoris, kilogramais.");
            double svoris = Convert.ToDouble(Console.ReadLine());
            double zmMasInd = ZmogausMasesIndekas(ugis, svoris);

            Console.WriteLine(zmMasInd);
            return zmMasInd;
        }

        static double ZmogausMasesIndekas(double ugis, double svoris)
        {
            double zmMasIndx = svoris / (ugis * ugis);
            return zmMasIndx;
        }

        static void Exercise1()
        {
            Console.WriteLine("Iveskite du sveikuosius skaicius.");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Suma(skaicius1, skaicius2);
            Skirtumas(skaicius1, skaicius2);
            Sandauga();
            Dalmuo(skaicius1, skaicius2);
        }
               
        static void Suma(int sk1, int sk2)
        {
            int suma = sk1 + sk2;
            Console.WriteLine(suma);
        }
        static void Skirtumas(int sk1, int sk2)
        {
            int skirtumas = sk1 - sk2;
            Console.WriteLine(skirtumas);
        }
        static void Sandauga(int sk1=5, int sk2=9)
        {
            int sandauga = sk1 * sk2;
            Console.WriteLine(sandauga);
        }
        static void Dalmuo(int sk1, int sk2)
        {
            if(sk2 == 0)
            {
                Console.WriteLine("Klaida");
            }
            else
            {
                int dalmuo = sk1 / sk2;
                Console.WriteLine(dalmuo);
            }
        }

        static void SayHello()
        {
            Console.WriteLine("Hello!!");
            SaySomething();
        }
        static void SaySomething()
        {
            Console.WriteLine("Say something!");
            for (int i = 0; i < 10; i++)
            {
                SayBye();
            }
        }
        static void SayBye()
        {
            Console.WriteLine("Bye.");
        }

        static void DoSum(string message, int leftNumber, int rightNumber, int skaicius = 10)
        {
            Console.WriteLine(message);
            Console.WriteLine(leftNumber + rightNumber);
        }
    }
}
