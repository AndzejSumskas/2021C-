using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson9
{
    class Bird : Animal
    {
        private protected string species;
        private protected string name;
        private DateTime dateBirth;
        private int quantity;
        private int weight;
        private int height;

        public Bird(int id, string marking, bool endangered, string species, string name, DateTime dateBirth, int quantity, int weight, int height) : base(id, marking, endangered)
        {
            this.species = species;
            this.name = name;
            this.dateBirth = dateBirth;
            this.quantity = quantity;
            this.weight = weight;
            this.height = height;
        }

        public Bird(int id, string marking, bool endangered, string species, string name, DateTime dateBirth) : base(id, marking, endangered)
        {
            this.species = species;
            this.name = name;
            this.dateBirth = dateBirth;
            base.id = id;
            base.marking = marking;
            base.endangered = endangered;

        }
    }
}
