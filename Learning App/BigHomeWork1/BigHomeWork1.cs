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
            //string ivestasTekstas = IvestiesMetodas();

            //bool tikrintiArSkaicius = TikrintiArSkaicius(ivestasTekstas);

            //bool tikrintiArSkaiciusReziuose = ArSkaiciusYraReziuose(tikrintiArSkaicius, ivestasTekstas);

            Console.WriteLine(ChangeNumberToText(Convert.ToInt32(Console.ReadLine())));    // Skaiciu nuo -9 iki 9 atspausdina zodziais

            Console.WriteLine(ChangeNumberToTextMinusPliusDevyniolika(Convert.ToInt32(Console.ReadLine())));

            

        }
       
        static string ChangeNumberToText(int ivestasSkaicius)
        {
            int laikinaSkacius = ivestasSkaicius;
            string zenklas = "";
            string skaicius = "";
            if (ivestasSkaicius < 0)
            {
                zenklas = "Minus ";
                laikinaSkacius = ivestasSkaicius - ivestasSkaicius - ivestasSkaicius;
            }
            else if (ivestasSkaicius > 0)
            {
                zenklas = "Plius ";
            }
            switch (laikinaSkacius)
            {
                case 0:
                    skaicius = "Nulis";
                    break;
                case 1:
                    skaicius = "vienas";
                    break;
                case 2:
                    skaicius = "du";
                    break;
                case 3:
                    skaicius = "trys";
                    break;
                case 4:
                    skaicius = "keturi";
                    break;
                case 5:
                    skaicius = "penki";
                    break;
                case 6:
                    skaicius = "sesi";
                    break;
                case 7:
                    skaicius = "septyni";
                    break;
                case 8:
                    skaicius = "astuoni";
                    break;
                case 9:
                    skaicius = "devyni";
                    break;
            }
            Console.WriteLine(zenklas + skaicius);
            return zenklas + skaicius;
        }



        static string ChangeNumberToTextMinusPliusDevyniolika(int ivestasSkaicius)
        {
            if(ivestasSkaicius < 20 && ivestasSkaicius > -20)
            {
                if(ivestasSkaicius < 10 && ivestasSkaicius > -10)
                {
                    return ChangeNumberToText(ivestasSkaicius);
                }
                else
                {
                    int laikinaSkacius = ivestasSkaicius;
                    string zenklas = "";
                    string skaicius = "";
                    if (ivestasSkaicius < 0)
                    {
                        zenklas = "Minus ";
                        laikinaSkacius = ivestasSkaicius-ivestasSkaicius-ivestasSkaicius;
                    }
                    else if (ivestasSkaicius > 0)
                    {
                        zenklas = "Plius ";
                    }
                    switch (laikinaSkacius)
                    {
                        case 10:
                            skaicius = "desimt";
                            break;
                        case 11:
                            skaicius = "vienuolika";
                            break;
                        case 12:
                            skaicius = "dvylika";
                            break;
                        case 13:
                            skaicius = "trylika";
                            break;
                        case 14:
                            skaicius = "keturiolika";
                            break;
                        case 15:
                            skaicius = "penkiolika";
                            break;
                        case 16:
                            skaicius = "sesiolika";
                            break;
                        case 17:
                            skaicius = "septyniiolika";
                            break;
                        case 18:
                            skaicius = "astuoniolika";
                            break;
                        case 19:
                            skaicius = "devyniolika";
                            break;
                    }
                    Console.WriteLine(zenklas + skaicius);
                    return zenklas + skaicius;
                }
            }
            return "Skaicius yra uz [-19..19] reziu ribos";

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
