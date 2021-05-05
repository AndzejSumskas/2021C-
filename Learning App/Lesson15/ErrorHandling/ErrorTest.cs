using Learning_App.Lesson15.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15.ErrorHandling
{
    class ErrorTest
    {
        public void DoSomethingBad()
        {
            throw new MySuperException("Do something bad!!!" , 156, 658);
        }
    }
}
