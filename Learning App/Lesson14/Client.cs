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
            clientCount++;
        }

        public int Clientid()
        {
            return clientCount;
        }
        public void PrintInfo()
        {

            Console.WriteLine(_name);
        }
    }
}
