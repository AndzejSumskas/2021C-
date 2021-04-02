using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson3.HomeWork3
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Pasirinkite norima preke:" +
            //    "\n1 - limonadas" +
            //    "\n2 - arbata" +
            //    "\n3 - kakava" +
            //    "\n4 - kava" +
            //    "\n5 - nieko");
            //int parinktis = Convert.ToInt32(Console.ReadLine());

            //switch (parinktis)
            //{
            //    case 1:
            //        Console.WriteLine("Jūs pasirinkote limonadą.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Jūs pasirinkote arbatą.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Jūs pasirinkote kakavą.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Jūs pasirinkote kavą.");
            //        break;
            //    case 5:
            //        Console.WriteLine("Jūs nieko nepasirinkote.");
            //        break;
            //    default:
            //        Console.WriteLine("Blogai įvestas pasirinkimas.");
            //        break;
            //}

            //Papildomos užduotys

            //Console.WriteLine("Įveskite skaičių");
            //int sk1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Įveskite skaičių");
            //int sk2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Įveskite skaičių");
            //int sk3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Įvestų skaičių sandauga yra " + (sk1*sk2*sk3));

            //****************************
            //Console.WriteLine("Įveskite skaičių");
            //int sk4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Įveskite skaičių");
            //int sk5 = Convert.ToInt32(Console.ReadLine());

            //if(sk5 == 0)
            //{
            //    Console.WriteLine($"{sk4} + {sk5} = {sk4 + sk5}" +
            //    $"\n{sk4} - {sk5} = {sk4 - sk5}" +
            //    $"\n{sk4} * {sk5} = {sk4 * sk5}");
            //}
            //else
            //{ 
            //Console.WriteLine($"{sk4} + {sk5} = {sk4+sk5}" +
            //    $"\n{sk4} - {sk5} = {sk4 - sk5}" +
            //    $"\n{sk4} * {sk5} = {sk4 * sk5}" +
            //    $"\n{sk4} / {sk5} = {(double)sk4 / sk5}");
            //}

            //****************************

            //Console.WriteLine("Įveskite skaičių");
            //int sk6 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Įveskite skaičių");
            //int sk7 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Įveskite skaičių");
            //int sk8 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Įveskite skaičių");
            //int sk9 = Convert.ToInt32(Console.ReadLine());

            //double rezultatas = (sk6 + sk7 + sk8 + sk9) / (double)4;

            //Console.WriteLine($"Skaičių {sk6}, {sk7}, {sk8}, {sk9} vidurkis yra: {rezultatas}.");

            //****************************

            //Console.WriteLine("Įveskite oro temperatūrą Farenheitais");
            //double farenheit = Convert.ToDouble(Console.ReadLine());
            //double celsius = (farenheit-32) * 5/9;
            //Console.WriteLine($"{farenheit} °F = {celsius} °C");

            //****************************

            //Kepykla

            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą?");
            double iskeptuKepaluPerH = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kiek darbuotojų turi kepykla?");
            int darbuotojuSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kokia yra vieno kepalo savikaina?");
            double kepaloSavikaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kokia yra vieno pardavimo kaina?");
            double kepaloPardavimoKaina= Convert.ToDouble(Console.ReadLine());

            const int darboValandos = 8;

            double iskeptuKepSkaiciusPerDiena = iskeptuKepaluPerH * darbuotojuSkaicius * darboValandos;

            double islaidos = iskeptuKepSkaiciusPerDiena * kepaloSavikaina;
            double pajamos = iskeptuKepSkaiciusPerDiena * kepaloPardavimoKaina;

            double pelnas = pajamos - islaidos;

            Console.WriteLine($"Per vieną darbo dieną kepykla iškepa {iskeptuKepSkaiciusPerDiena} duonos kepalų.");
            Console.WriteLine($"Visų kelapų savikaina {islaidos}.");
            Console.WriteLine($"Gautos pajamos pardavus {pajamos}.");
            Console.WriteLine($"Pelnas = {pelnas}.");


        }
    }
}
