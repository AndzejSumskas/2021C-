using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson8.Factory
{
    class Client
    {
        public string Name;
        public string SecondName;
        private int idCode;
        private Parduotuve parduotuve;

        public Client(string name, string secondName, int idCode, Parduotuve parduotuve)
        {
            Name = name;
            SecondName = secondName;
            this.idCode = idCode;
            this.parduotuve = parduotuve;
        }


        public void choseBestGoods()
        {

        }

        public void goodsReturn()
        {

        }

    }
}
