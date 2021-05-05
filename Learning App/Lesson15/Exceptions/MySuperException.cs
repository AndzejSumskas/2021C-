using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15.Exceptions
{
    class MySuperException : Exception
    {
        private int x;
        private int y;

        public MySuperException(string message, int x, int y) : base(message)
        {
            this.x = x;
            this.y = y;
        }
    }
}
