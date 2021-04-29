using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson14
{
    class Human : LiveObject, IPrintMe
    {
        public static Random rng = new Random();

        private string _name;

        protected string Name
        {
            get { return _name; } }
           

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
            Console.WriteLine("Generate live span: {0}", GetLiveSpan());
        }

       
    }
}
