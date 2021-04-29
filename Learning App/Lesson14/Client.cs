using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson14
{
    sealed class Client : Human, IPrintMe
    {
        private static int clientCount = 0;

        public Client(string _name) : base(_name)
        {
            Clientid = clientCount++;
        }

        public int Clientid { get; private set; }
       
        public void PrintInfo()
        {

            Console.WriteLine(Name);
        }
    }
}
