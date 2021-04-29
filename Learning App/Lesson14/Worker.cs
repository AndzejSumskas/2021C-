using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson14
{
    sealed class Worker : Human
    {
        private int _salary;

        public Worker(string _name, int salary) : base(_name)
        {
            _salary = salary;
        }

        public int GetSalary()
        {
            return _salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {_salary}" );
        }

        public void SetSalary(int salary)
        {
            _salary = salary;
        }
    }
}
