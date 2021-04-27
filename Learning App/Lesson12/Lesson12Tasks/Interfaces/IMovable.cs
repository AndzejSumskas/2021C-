using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.Lesson12Tasks.Interfaces
{
    interface IMovable
    {
        int X { get; set; }
        int Y { get; set; }

        void Move();

        //event EventHandler OnVlick;
    }
}
