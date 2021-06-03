using Learning_App.FinalBigHomeWork.Data;
using Learning_App.FinalBigHomeWork.Gui;
using Learning_App.FinalBigHomeWork.Units;
using Learning_App.FinalBigHomeWork.Windows;
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
            Console.CursorVisible = false;
            GuiController guiController = new GuiController();
            guiController.StartAplication();

            GameData data = new GameData();
            //data.GameAreaData();

            //ActionWindow actionWindow = new ActionWindow();
            //data.player.currentTankModel = data.player.tankModel[0];
            //actionWindow.Render();
           
           // data.player.Render();







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
