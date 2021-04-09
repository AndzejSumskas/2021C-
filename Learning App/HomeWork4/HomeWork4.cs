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
            //FibanacioSeka();

            //WhileUzduotis();

            Skaiciuotuvas();
       
        }

        static void Skaiciuotuvas()
        {
            bool baigtiSkaiciavimus = true;
            do
            {
                double sk1, sk2, atsakymas = 0;
                bool ivestis = true;
                char keyPress = ' ';

                Console.WriteLine("Iveskite 1 skaiciu");
                sk1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Iveskite 2 skaiciu");
                sk2 = double.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Iveskite veiksma(+,-,*,/,%).");
                    //veiksmas = Convert.ToString(Console.ReadLine());
                    keyPress = Console.ReadKey(true).KeyChar;
                    switch (keyPress)
                    {
                        case '+':
                            atsakymas = sk1 + sk2;
                            ivestis = false;
                            break;
                        case '-':
                            atsakymas = sk1 - sk2;
                            break;
                            ivestis = false;
                            break;
                        case '*':
                            atsakymas = sk1 * sk2;
                            ivestis = false;
                            break;
                        case '/':
                            if (sk2 == 0)
                            {
                                ;
                                Console.WriteLine("Klaida!!! Is 0 nesidalyja!!!");
                                break;
                            }
                            atsakymas = sk1 / sk2;
                            ivestis = false;
                            break;
                        case '%':
                            atsakymas = sk1 % sk2;
                            ivestis = false;
                            break;
                        default:
                            Console.WriteLine("Blogai ivestas veiksmas!!!");
                            break;
                    }

                } while (ivestis);

                Console.WriteLine($"{sk1} {keyPress} {sk2} = {atsakymas}");

                Console.WriteLine("Baigti - n, testi - bet kuri kita");

                char keyPressLast = Console.ReadKey(true).KeyChar;
                if(keyPressLast == 'n')
                {
                    baigtiSkaiciavimus = false;
                }

            } while (baigtiSkaiciavimus);
        }

        static void WhileUzduotis()
        {
            int skaicius = new Random().Next(0, 100);
            int spejimuSkaicius = 0;
            bool arAtspeta = true;
            while (arAtspeta)
            {
                Console.WriteLine("Atspekite skaiciu nuo 0 iki 100.");
                int spejimas = Convert.ToInt32(Console.ReadLine());
                spejimuSkaicius++;
                if (spejimas > skaicius)
                {
                    Console.WriteLine("Mazesnis!");
                }
                else if (spejimas < skaicius)
                {
                    Console.WriteLine("Didesnis!");
                }
                else
                {
                    Console.WriteLine("Atspejote is {0} karto!", spejimuSkaicius);
                    arAtspeta = false;
                }
            }
        }
        static void FibanacioSeka()
        {
            int sk1 = 0;
            int sk2 = 1;
            int temp;
            Console.WriteLine("Fibonacio skaiciu kiekis:");
            int FSkaiciuKiekis = Convert.ToInt32(Console.ReadLine());

            if (FSkaiciuKiekis >= 1)
            {
                Console.Write("0 ");
            }
            if (FSkaiciuKiekis >= 2)
            {
                Console.Write("1 ");
            }
            if (FSkaiciuKiekis > 2)
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
