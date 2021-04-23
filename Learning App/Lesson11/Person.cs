using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson11
{
    class Person
    {
        public string name = "Jonas";
        public string city = "Vilnius";
        public string school = "Sirokomles";
        public string college = "vtdk";


        private string vardas { get; set; } = "Saulius";
        private string miestas { get; } = "Vilnius";

        public string mokykla
        {
            set
            {
                mokykla = value;
            }

        }
        private string kolegija { get; set; } = "Vilniaus";


        public string Vardas
        {
            get { return vardas; }
            set { vardas = value; }
        }

        public string Miestas
        {
            get { return miestas; }
        }

        public string Mokykla
        {
            set
            {
                mokykla = "Lazdynu";
            }
        }

        public string Kolegija
        {
            get { return kolegija; }
            set { kolegija = value; }
        }
    }
}
