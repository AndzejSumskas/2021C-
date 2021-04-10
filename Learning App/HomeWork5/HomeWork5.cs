using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            // UzduotisPapildoma();
            // GetInput("Iveskite skaiciu");

            //PapildomaUzduotisMaxValue();  //1 uzduotis
            //PapildomaUzduotisInRange();    // 2 uzduotis
            //PapildomaUzduotisIsPrimal();     // 3 uzduotis
            //Console.WriteLine($" D6:{D6()}, D10:{D10()}, D20:{D20()}");     //4uzduotis
            GrazinamasSkaiciusReziuose(-18, 256);

        }

        static int GrazinamasSkaiciusReziuose(int sk1, int sk2)
        {
            int skaicius1, skaicius2, ivestis;
            if (sk1 < sk2)
            {
                skaicius1 = sk1;
                skaicius2 = sk2;
            }
            else
            {
                skaicius1 = sk2;
                skaicius2 = sk1;
            }
            do
            {
                Console.WriteLine("Irasykite skaiciu tarp {0} ir {1}", skaicius1, skaicius2);
                ivestis = InputValue();
            } while (ivestis < skaicius1 || ivestis > skaicius2);

            return ivestis;
        }

        static int RNG(int sk1, int sk2)
        {
            Random rng = new Random();
            return rng.Next(sk1, sk2);
        }

        static int D20() { return RNG(1, 20); }
        static int D10() { return RNG(1, 10); }
        static int D6() { return RNG(1, 6); }


        static void PapildomaUzduotisIsPrimal()
        {
            Console.WriteLine(IsPrimal(InputValue()));
        }
        static bool IsPrimal(int sk)
        {

            for (int i = 2; i < sk; i++)
            {
                if (sk % i ==0)
                return false;
                }
            return true;

        }

        static void PapildomaUzduotisInRange()
        {
            Console.WriteLine(InRange(InputValue(), InputValue(), InputValue()));
        }
        static bool InRange(int sk1, int sk2, int sk3)
        {
            if(sk1 < sk2 && sk1 > sk3 || sk1 > sk2 && sk1 < sk3)
            {
                return true;
            }
            return false;
        }
        static void PapildomaUzduotisMaxValue()
        {
            int atsakymas = MaxValue(InputValue(), InputValue(), InputValue());
            Console.WriteLine("Didziausias skaicius: {0}", atsakymas);
        }
        static int InputValue()
        {
            Console.WriteLine("Parasykite sveikaji skaiciu!!!");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int MaxValue(int sk1, int sk2, int sk3)
        {
            if (sk1 > sk2 && sk1 > sk3 || sk1 > sk2 && sk1 == sk3 || sk1 == sk2 && sk1 > sk3)
            {
                return sk1;
            }
            else if (sk2 > sk1 && sk2 > sk3 || sk2 > sk1 && sk2 == sk3)
            {
                return sk2;
            }
            else
                return sk3;
        }

        static void UzduotisPapildoma()
        {
            int sk1 = 5;
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("Plius vienas: " + (sk1 + 1));
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("PassAsRef");
            PassAsRef(ref sk1);                //Keiti skaiciu pagal nuoroda
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("PassAsNormal");
            PassAsNormal(sk1);
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("PassAsOut");
            PassAsOut(out sk1);                  //Gaves kintamojo nuoruoda, metode priskiri reiksme
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("PassAsOut");
            PassAsIn(sk1);                      // nuskaitai skaiciu
            Console.WriteLine("skaicius: " + sk1);
        }

        static void PassAsIn(in int skaicius)
        {
            Console.WriteLine(skaicius);
        }
        static void PassAsOut(out int skaicius)
        {
            skaicius = 18;
            Console.WriteLine(skaicius);
            skaicius -= 10;
            Console.WriteLine(skaicius);
        }
        static void PassAsNormal(int skaicius)
        {
            Console.WriteLine(skaicius);
            skaicius++;
            Console.WriteLine(skaicius);
        }
        static void PassAsRef(ref int skacius)
        {
            Console.WriteLine(skacius);
            skacius += 6;
            Console.WriteLine(skacius);
        }
        static int GetInput(string message)
        {
            Console.WriteLine(message);
            int retVal;
            while(!int.TryParse(Console.ReadLine(), out retVal))
            {
                Console.WriteLine("...bad input, not int!");
                Console.WriteLine(message);
            }
            return retVal;
        }
    }
}
