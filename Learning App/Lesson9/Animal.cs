using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson9
{
    class Animal
    {
        private protected int id;
        private protected string marking;
        private protected bool endangered;

        public Animal(int id, string marking, bool endangered)
        {
            this.id = id;
            this.marking = marking;
            this.endangered = endangered;
        }
    }
}
