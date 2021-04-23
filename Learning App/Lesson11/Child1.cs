using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson11
{
    class Child1 : Parent
    {

        public override void Funkcija()
        {
            base.Funkcija();

            Console.WriteLine("override");
        }

        public new void Funkcija2()
        {
            Console.WriteLine("Nauja funkcija, perdengimas");
        }
        public override void BestMethod()
        {
            base.BestMethod();
            Console.WriteLine("sdfsdf");
        }
    }
}
                                      