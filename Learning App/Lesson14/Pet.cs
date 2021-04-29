using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson14
{
    class Pet : LiveObject, IPrintMe
    {
        static Random rng = new Random();
        public override int GetLiveSpan()
        {
            return rng.Next(5, 18);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Lives {0}", GetLiveSpan());
        }
    }
}
