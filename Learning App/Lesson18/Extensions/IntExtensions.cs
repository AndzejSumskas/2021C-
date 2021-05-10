using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson18.Extensions
{
    public static class IntExtensions
    {
        public static int PowerTwo(this int number)
        {
            return number*number;
        }
    }
}
