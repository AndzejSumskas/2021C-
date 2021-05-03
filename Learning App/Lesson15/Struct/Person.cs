using Learning_App.Lesson12.InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson15
{
    struct Person : IRenderable
    {
        public string Name;
        public string SurName;

        public Person(string name, string surName)
        {
            Name = name;
            SurName = surName;
        }

        public string GetFullName()
        {
            return Name + " " + SurName;
        }

        public void Render()
        {

        }
    }
}
