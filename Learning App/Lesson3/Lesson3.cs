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

            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine(skaicius1 + skaicius2 + skaicius3);
                    break;
                case 2:
                    Console.WriteLine(skaicius1 - skaicius3);
                    break;
                case 3:
                    Console.WriteLine(skaicius2 * skaicius3);
                    break;
                default:
                    Console.WriteLine("Klaida");
                    break;
            }                
        }
     }  
}
