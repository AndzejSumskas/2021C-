﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.InterfaceTask.Interfaces
{
    interface IGlows
    {
        int glowPower { get; set; }

        void Glow();
    }
}
