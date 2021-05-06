using Learning_App.Lesson17.LessonTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson17
{
    class Table
    {
        private int legCount;

        private MyAction action;


        public void Untold()
        {

        }
        public void Fold()
        {

        }

        internal void AddFood(string v)
        {
            throw new NotImplementedException();
        }

        internal void DoAction(Func<int, int, bool, int> customAction)
        {
           // action = customAction;
        }
    }
}
