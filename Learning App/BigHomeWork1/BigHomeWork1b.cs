using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork1
{
    class Program1
    {
        static void Main(string[] args)
        {
            //string ivestasTekstas = IvestiesMetodas();

            //bool tikrintiArSkaicius = TikrintiArSkaicius(ivestasTekstas);

            //bool tikrintiArSkaiciusReziuose = ArSkaiciusYraReziuose(tikrintiArSkaicius, ivestasTekstas);

            //Patikrinu ar skaicius yra reziuose [-9..9]. Jei yra tai pavercia skaicius i zodzius.

            //int skaicius = Convert.ToInt32(Console.ReadLine());
            //if(ArSkaiciusYraReziuose(Convert.ToString(skaicius)))
            //{
            //    Console.WriteLine(ChangeSignToText(skaicius) + ChangeNumberToTextMinusPliusDevyni(skaicius));
            //}

            //Skaicius nuo -19 iki 19 pavercia i string.

            //int skaicius2 = IvestiesMetodas();
            //Console.WriteLine(ChangeSignToText(skaicius2)+ ChangeNumberToTextMinusPliusDevyniolika(skaicius2));

            // Skaicius nuo -99 iki 99 pavercia i string.

            //int skaicius3 = IvestiesMetodas();
            //Console.WriteLine(ChangeSignToText(skaicius3) + ChangeNumberToTextMinusPlius99(skaicius3));

            //Skaicius nuo -999 iki 999 pavercia i string.

            int skaicius4 = IvestiesMetodas();

            Console.WriteLine(ChangeSignToText(skaicius4) + ChangeNumberToTextMinusPlius999(skaicius4));


        }
        static string ChangeNumberToTextMinusPlius999(int ivestasSkaicius)
        {
            if(ivestasSkaicius<100 && ivestasSkaicius>-100)
            {
                return ChangeNumberToTextMinusPlius99(ivestasSkaicius);
            }
            else if(ivestasSkaicius < 1000 && ivestasSkaicius > -1000)
            {
                int simtai = ivestasSkaicius / 100;
                int liekana = ivestasSkaicius % 100;
                string maziausSimtuTekstas = "";
                string simtuTekstas = ChangeNumberToTextMinusPliusDevyni(simtai);
                if(liekana !=0)
                {
                    maziausSimtuTekstas = ChangeNumberToTextMinusPlius99(liekana);
                }
                return simtuTekstas + "simtai " + maziausSimtuTekstas;

            }
            return "";
        }

        static string ChangeNumberToTextMinusPlius99 (int ivestasSkaicius)
        {
            if (ivestasSkaicius < 20 && ivestasSkaicius > -20)
            {
                return ChangeNumberToTextMinusPliusDevyniolika(ivestasSkaicius);
            }
            else if(ivestasSkaicius < 100 && ivestasSkaicius > -100)
            {
                string skaiciusMaziauDesimt = "";
                Desimtys(ivestasSkaicius);
                int liekana = ivestasSkaicius % 10;
                if(liekana != 0)
                {
                    skaiciusMaziauDesimt =  ChangeNumberToTextMinusPliusDevyni(liekana);
                }
                return Desimtys(ivestasSkaicius) + skaiciusMaziauDesimt; 
            }

            return "";
        }
        static string Desimtys(int ivestasSkaicius)
        {
            string skaicius = "";
            int desimtys = ivestasSkaicius / 10;

            if (ivestasSkaicius<0)
            {
                desimtys = desimtys - desimtys - desimtys;
            }
            switch (desimtys)
            {
                case 2:
                    skaicius = "dvidesimt ";
                    break;
                case 3:
                    skaicius = "trisdesimt ";
                    break;
                case 4:
                    skaicius = "keturiasdesimt ";
                    break;
                case 5:
                    skaicius = "penkiasdesimt ";
                    break;
                case 6:
                    skaicius = "sesiasdesimt ";
                    break;
                case 7:
                    skaicius = "septyniasdesimt ";
                    break;
                case 8:
                    skaicius = "astuoniasdesimt ";
                    break;
                case 9:
                    skaicius = "devyniasdesimt ";
                    break;
            }
            return skaicius;
        }

        
        static string ChangeNumberToTextMinusPliusDevyniolika(int ivestasSkaicius)
        {
            if (ivestasSkaicius < 20 && ivestasSkaicius > -20)
            {
                int laikinaSkacius = ivestasSkaicius;
                if (ivestasSkaicius < 0)
                {
                    laikinaSkacius = ivestasSkaicius - ivestasSkaicius - ivestasSkaicius;
                }
                if (ivestasSkaicius < 10 && ivestasSkaicius > -10)
                {
                    return ChangeNumberToTextMinusPliusDevyni(ivestasSkaicius);
                }
                else
                {
                    string skaicius = "";
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
                    return skaicius;
                }
            }
            return "Skaicius yra uz [-19..19] reziu ribos";
        }

        static string ChangeNumberToTextMinusPliusDevyni(int ivestasSkaicius)
        {
            int laikinaSkacius = ivestasSkaicius;
            string skaicius = "";
            if (ivestasSkaicius < 0)
            {
                laikinaSkacius = ivestasSkaicius - ivestasSkaicius - ivestasSkaicius;
            }
            switch (laikinaSkacius)
            {
                case 1:
                    skaicius = "vienas ";
                    break;
                case 2:
                    skaicius = "du ";
                    break;
                case 3:
                    skaicius = "trys ";
                    break;
                case 4:
                    skaicius = "keturi ";
                    break;
                case 5:
                    skaicius = "penki ";
                    break;
                case 6:
                    skaicius = "sesi ";
                    break;
                case 7:
                    skaicius = "septyni ";
                    break;
                case 8:
                    skaicius = "astuoni ";
                    break;
                case 9:
                    skaicius = "devyni ";
                    break;
            }

            return skaicius;
        }

        static string ChangeSignToText(int ivestasSkaicius)
        {
            if (ivestasSkaicius < 0)
            {
                return "Minus ";
                
            }
            else if (ivestasSkaicius > 0)
            {
                return "Plius ";
            }
            return "Nulis";
        }

        static bool ArSkaiciusYraReziuose(string ivestasTekstas)
        {
            bool tikrintiArSkaiciusReziuose = true;
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
        static int IvestiesMetodas()
        {
            Console.WriteLine("Iveskite skaiciu");
            int ivestis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ivestis: {ivestis}");
            return ivestis;
        }
        static bool TikrintiArSkaicius(string zodis)
        {
            char simbolis = zodis[0];
            int j = 0;
            if (simbolis == '-' || simbolis == '+')
            {
                j++;
            }
            if (true)
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