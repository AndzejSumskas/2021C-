using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ivestasTekstas = IvestiesMetodas();

            bool tikrintiArSkaicius = TikrintiArSkaicius(ivestasTekstas);

            bool tikrintiArSkaiciusReziuose = ArSkaiciusYraReziuose(tikrintiArSkaicius, ivestasTekstas);

        }

        static bool ArSkaiciusYraReziuose(bool tikrintiArSkaiciusReziuose, string ivestasTekstas)
        {

            if (tikrintiArSkaiciusReziuose == true)
            {
                int skaicius = Convert.ToInt32(ivestasTekstas);
                if (skaicius >= -9 && skaicius <= 9)
                {
                    Console.WriteLine("Skaicius yra reziuose [-9..9]");
                    return true;
                }
                else
                {
                    Console.WriteLine("Skaicius yra uz [-9..9] reziu ribos");
                    return false;
                }
            }
                    else
            {
                Console.WriteLine("Ivestis: ne skaicius");
                return false;
            }
        }

        static string IvestiesMetodas(string message = "Iveskite skaiciu [-9...9]")
        {
            Console.WriteLine(message);
            string ivestis = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Ivestis: {ivestis}");
            return ivestis;
        }
        static bool TikrintiArSkaicius(string zodis)
        {
            char simbolis = zodis[0];
            int j=0;
            if (simbolis == '-' || simbolis == '+')
            {
               j++;
            }
            if(true)
            {
                for (int i = j; i < zodis.Length; i++)
                {
                    simbolis = zodis[i];
                    switch (simbolis)
                    {
                        case '1':
                            break;
                        case '2':
                            break;
                        case '3':
                            break;
                        case '4':
                            break;
                        case '5':
                            break;
                        case '6':
                            break;
                        case '7':
                            break;
                        case '8':
                            break;
                        case '9':
                            break;
                        case '0':
                            break;
                        default:
                            Console.WriteLine("Ivestis ne skaicius.");
                            return false;           
                    }
                }
                Console.WriteLine("Ivestis yra skaicius");
                return true;
            }
        }
    }
}
