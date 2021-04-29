using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson14
{
    class Dog : Pet, IPrintMe
    {
        static Random rng = new Random();

        private string _name;

        public Dog(string name)
        {
            _name = name;
        }
        public override int GetLiveSpan()
        {
            return rng.Next(5, 18);
        }

        public void PrintInfo()
        {
            Console.Write($"Dog name {_name}. ");
            Pet p = new Pet();
            p.PrintInfo();
        }
    }
}
