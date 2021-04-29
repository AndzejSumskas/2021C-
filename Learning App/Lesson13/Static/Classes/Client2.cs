using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson13.Classes
{
    class Client2
    {
        static private int CreateCount = 0;

        public Client2()
        {
            CreateCount++;
        }

        public static int GetClientCount()
        {
            return CreateCount;
        }
    }
}
