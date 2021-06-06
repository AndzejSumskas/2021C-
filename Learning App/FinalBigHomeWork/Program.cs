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
            //data.GameAreaDataToStartGame(); // for testing

            Console.ReadKey();
        }
    }
}
