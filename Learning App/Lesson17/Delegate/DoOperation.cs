using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson17.Delegate
{
    public delegate int DoOperation(int m1, int m2);

    class TestDelegate
    {
        DoOperation doOperation0 = new DoOperation(MyMultiply);

        

        internal static int MyMultiply(int m1, int m2)
        {
            return m1 * m2;
        }

        internal static int MySum(int m1, int m2)
        {
            return m1 + m2;
        }
    }

    
}
