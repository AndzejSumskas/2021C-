
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson12.InterfaceTask.Objects
{
    class PetEnumerator : IEnumerator
    {
        int curentId = 0;
        private Dog dog;

        public PetEnumerator(Dog dog)
        {
            this.dog = dog;
        }

        public object Current
        {
            get
            {
                switch(curentId)
                {
                    case 1: return dog.Name; break;
                    case 2: return dog.Kind; break;
                    case 3: return dog.Color; break;
                    case 4: return dog.Character; break;
                }
                return null;
            }
        }

        public bool MoveNext()
        {
            curentId++;
            return curentId < 5;
        }

        public void Reset()
        {
            curentId = 0;
        }
    }
}
