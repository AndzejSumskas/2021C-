using Learning_App.FinalBigHomeWork.Gui;
using Learning_App.FinalBigHomeWork.Units;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.FinalBigHomeWork
{
    class Program
    {
        static void Main()
        {
           
            GuiController guiController = new GuiController();
            guiController.StartAplication();

            //BoardGame b = new BoardGame();
            //b.gameController();
            //int[,] boardGame = b.GetBalteAreaArray();





            //Console.WriteLine("▒▒▒▒▒▒");
            //Console.WriteLine("  ██==");
            //Console.WriteLine("▒▒▒▒▒▒");

            //Console.WriteLine();


            //Console.WriteLine("▒▒¦¦▒▒");
            //Console.WriteLine("▒▒██▒▒");
            //Console.WriteLine("▒▒  ▒▒");


            Console.ReadKey();
        }
    }
}
