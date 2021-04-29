using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson14
{
    class Human : LiveObject, IPrintMe
    {
        static Random rng = new Random();

        protected string _name;

        public Human(string name)
        {
            _name = name;
        }

        public override int GetLiveSpan()
        {
            return rng.Next(50, 100);
        }

        public void PrintInfo()
        {
            //Console.WriteLine("Name {0}", _name);
            Console.WriteLine("Generate live span: {0}", GetLiveSpan());
        }

       
    }
}
