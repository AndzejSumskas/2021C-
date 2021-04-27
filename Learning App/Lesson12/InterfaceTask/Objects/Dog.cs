using Learning_App.Lesson12.InterfaceTask.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.InterfaceTask.Objects
{
    class Dog : IPrintable, IMovable, IRenderable
    {

        public string Name { get; set; } = "Pupsik";
        public string Kind { get; set; } = "unknown";
        public string Color { get; set; } = "Black";
        public string Character { get; set; } = "frendly";

        private int x;

        public int X { get { return x; } set { x = value; } }
        public int Y { get; set ; }

        public IEnumerator GetEnumerator()
        {
            return new PetEnumerator(this);
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Dog print!"); 
        }

        public void Render()
        {
            Console.WriteLine("Dog render!"); ;
        }
    }
}
