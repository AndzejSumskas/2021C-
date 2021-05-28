using Learning_App.BigHomeWork4Task.Game;
using Learning_App.BigHomeWork4Task.Gui;
using Learning_App.BigHomeWork4Task.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork4Task
{
    class Programe
    {
        static void Main()
        {
            Console.CursorVisible = false;


            GuiManager guiManager = new GuiManager();

            guiManager.StartAplication();

            Console.ReadKey();
        }
    }
}
