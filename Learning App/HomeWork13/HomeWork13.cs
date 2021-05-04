using Learning_App.Lesson13.PrintHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.HomeWork13
{
    class HomeWork13
    {
        static void Main()
        {
            //PrintHelper.Print("Month", "July", "November", 3, "2");

            //PrintHelper.PrintTable("Month", "July", "November", 3, "2", 3.25);

            //StringHelper.SplitTextToWords("Labas, as Tomas. Man astuoniolika metu. Gyvenu Kaune.");

            //StringHelper.SplitTextToWords2("Labas, as Tomas. Man astuoniolika metu. Gyvenu Kaune.");


            string txt = StringHelper.SplitCammelCase("Labas, As Tomas. Man Astuoniolika Metu. Gyvenu Kaune.");

            Console.WriteLine(txt);
        }
    }
}
