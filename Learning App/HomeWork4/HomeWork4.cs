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
            int sk1 = 0;
            int sk2 = 1;
            int temp;
            int FSkaiciuKiekis=Convert.ToInt32(Console.ReadLine());

            if (FSkaiciuKiekis >= 1) 
            {
                Console.Write("0 ");
            }
            if(FSkaiciuKiekis >= 2)
            {
                Console.Write("1 ");
            }

            if(FSkaiciuKiekis>2)
            {
                for (int i = 0; i < FSkaiciuKiekis - 2; i++)
                {
                    temp = sk1 + sk2;
                    sk1 = sk2;
                    sk2 = temp;
                    Console.Write(temp + " ");
                }
            }     
        }
    }
}
