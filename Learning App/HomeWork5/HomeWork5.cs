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
            int sk1 = 5;
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("Plius vienas: " + (sk1 +1));
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("PassAsRef");
            PassAsRef(ref sk1);                //Keiti skaiciu pagal nuoroda
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("PassAsNormal");
            PassAsNormal(sk1);
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("PassAsOut");
            PassAsOut(out sk1);
            Console.WriteLine("skaicius: " + sk1);
            Console.WriteLine("PassAsOut");
            PassAsIn(sk1);
            Console.WriteLine("skaicius: " + sk1);

            GetInput("Iveskite skaiciu");
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
