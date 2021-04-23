using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson11
{
    class Parent : AbstractClass
    {


        public virtual void Funkcija()
        {
            Console.WriteLine("funkcija1");
        }
        public  void Funkcija2()
        {
            Console.WriteLine("funkcija2");
        }
        public void Funkcija3()
        {
            Console.WriteLine("funkcija3");
        }

        public override void BestMethod()
        {
            base.BestMethod();
            Console.WriteLine("Parrent class");
        }
    }
}

    
