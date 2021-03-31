using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson3
{
     class Lesson3
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Parasykite sveikaji skaiciu.");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parasykite sveikaji skaiciu.");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parasykite sveikaji skaiciu.");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            if(skaicius1 > skaicius2 && skaicius1 >skaicius3)
            {
                Console.WriteLine(1);
            }
            else if(skaicius2 > skaicius3 && skaicius2 > skaicius1)
            {
                Console.WriteLine(2);
            }
            else if(skaicius3 > skaicius1 && skaicius3 > skaicius2)
            {
                Console.WriteLine(3);
            }
            

            if(skaicius1 >skaicius2 && skaicius1 <100)
            {
                Console.WriteLine("sk1 > sk2 ir <100");
            }
            if(skaicius2 >0 && skaicius2 >skaicius1)
            {
                Console.WriteLine("sk2 >0 ir sk2>sk1");
            }
            if(skaicius1>skaicius2)
            {

            }
                        
        }
     }
    
}
