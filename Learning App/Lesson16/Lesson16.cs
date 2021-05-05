using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.Lesson16.StringTask;

namespace Learning_App.Lesson16
{
    class Lesson16
    {
        static void Main()
        {
            //*****************************************************************************************************
            // Adressas :    C:\Users\Andzej\Desktop\C#\01Paskaita\LearningAppGit\Learning App\bin\Debug\net5.0
            // Zingsnis atgal : ../   :  C:\Users\Andzej\Desktop\C#\01Paskaita\LearningAppGit\Learning App\bin\Debug
            //*****************************************************************************************************

            File.WriteAllText("test.txt", "Hello World!.."); 
            File.WriteAllText("../test2.txt", "Hello World!..");

            string path = "test.txt";

            //*************NAUJO TEKSTO IRASYMAS I PASIRINKTA APLANKALA!!!!*********************

            File.WriteAllText(@"C:\Users\Andzej\Desktop\C#\01Paskaita\LearningAppGit\Learning App\bin\Debug\net5.0\test7", "Naujo teksto irasymas i pasirinkta aplankala");

            string manoFailoTekstas = File.ReadAllText("test.txt");

            Console.WriteLine(manoFailoTekstas);
            string text = "TExtas tasxsdasd";
            File.AppendAllText(path, text);

            Console.WriteLine("****************");

            string readAllText = File.ReadAllText(path);
            File.Delete(manoFailoTekstas);
            Console.WriteLine(readAllText);

            if(File.Exists(path))
            {
                Console.WriteLine("Egzistuoja");
            }

        }

        private void Lesson15()
        {
            TaskString n = new TaskString();
            n.TestStringTask();
        }
    }
}
