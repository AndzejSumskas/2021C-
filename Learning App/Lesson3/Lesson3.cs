using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson3
{
     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Parasykite sveikaji skaiciu.");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parasykite sveikaji skaiciu.");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parasykite sveikaji skaiciu.");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            if(skaicius1>skaicius2 && skaicius1 >skaicius3)
            {
                Console.WriteLine("1 skaicius didziausias.");
            }
            else if(skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine("2 skaicius didziausias.");
            }
            else if (skaicius3 > skaicius2 && skaicius3 > skaicius1)
            {
                Console.WriteLine("3 skaicius didziausias.");
            }
            else if (skaicius1 == skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("1 ir 2 skaiciai didziausi.");
            }
            else if (skaicius1 == skaicius3 && skaicius1 > skaicius2)
            {
                Console.WriteLine("1 ir 3 skaiciai didziausi.");
            }
            else if (skaicius2 == skaicius3 && skaicius2 > skaicius1)
            {
                Console.WriteLine("2 ir 3 skaiciai didziausi.");
            }
            else { Console.WriteLine("Visi skaiciai lygus."); }

            //***********************************************

            if (skaicius1 > skaicius2 && skaicius1 < 100) 
            {
                Console.WriteLine("1");
            }
            if (skaicius2 > 0 && skaicius2 > skaicius1) 
            {
                Console.WriteLine("2");
            }
            if (skaicius1 > skaicius2 && skaicius1 > skaicius3 || skaicius1 > 0)
            {
                Console.WriteLine("3");
            }
            if (5 <= skaicius3 && skaicius3 >= 10 || skaicius3 > skaicius2)
            {
                Console.WriteLine("4");
            }

            //switch uzduotis

            switch (skaicius1)
            {
                case 3:
                    Console.WriteLine(skaicius2 * skaicius3);
                    break;
                case 2:
                    Console.WriteLine(skaicius1 - skaicius3);
                    break;
                case 1:
                    Console.WriteLine(skaicius1 + skaicius2 + skaicius3);
                    break;
                default:
                    Console.WriteLine("Klaida");
                    break;
            }                
        }
     }  
}
