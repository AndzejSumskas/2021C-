using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tekstai = new string[5];

            string[] tesada = new[] { "1sdasd", "2sdas", "3sdasd", "4sdasd", "5sdasd" };
            //PrintArray(tekstai);

           // PrintArrayTextInOneLine(tesada); //Tektas vienoje eiluteje be tarpu
           // PrintArrayTextInOneLineViceVersa(tesada);  //Tektas vienuoje eiluteje be tarpu(atvirkciai)

            //Exercise2(Data);

            MasyvaSuSauktukaisGale(Data);

            MasyvaSuSauktukaisGale(Data);            // Pries taip privalo veikti Execose2, kitaip masyvas netures sauktuku
        }

        
        static string PrintArrayTextInOneLineViceVersa(string[] txt)
        {
            string[] tempArray = new string [5];
            int counter = 4;
            foreach (var item in txt)
            {
                tempArray[counter] = item;
                counter--;
            }            
            return PrintArrayTextInOneLine(tempArray);
        }
        static string PrintArrayTextInOneLine(string[] txt)
        {
            string allTextInLine = "";
            foreach (var item in txt)
            {
                allTextInLine += item;
            }
            Console.WriteLine(allTextInLine);
            return allTextInLine;
        }

        static void PrintArray(string[] txt)
        {
            for (int i = 0; i < 5; i++)
            {
                txt[i] = TekstoIvedimas();
                Console.WriteLine(txt[i]);
            }
        }

        static string TekstoIvedimas()
        {
            Console.WriteLine("Iveskite teksta.");
            return Convert.ToString(Console.ReadLine());      
        }

        static string[] Data = new[] { "Mano", "batai", "Mano", "buvo", "du", "buvo", "du", "." };

        static void Exercise2(string[] datas)
        {
            string[] tempArray = datas;

            for (int i = 0; i < datas.Length; i++)
            {
                string firstItem = datas[i];
                for (int j = i + 1; j < datas.Length; j++)
                {                   
                    string secondItem = datas[j];
                    if(firstItem == secondItem)
                    {
                        datas[j] = "!";
                    }
                }
                Console.Write(datas[i] + " ");
            }

        }

        static void MasyvaSuSauktukaisGale(string[] datas)
        {
            int nuoGalo = Data.Length - 1;
            int nuoPradziu = 0;

            string[] masyvasSuSauktukasiGale1 = new string[Data.Length];

            foreach (var item in Data)
            {
                if (item == "!")
                {
                    masyvasSuSauktukasiGale1[nuoGalo] = item;
                    nuoGalo--;
                }
                else
                    masyvasSuSauktukasiGale1[nuoPradziu] = item;
                nuoPradziu++;
            }
            Console.WriteLine();
            foreach (var item in masyvasSuSauktukasiGale1)
            {
                Console.Write(item + " ");
            }
        }
    }
}
