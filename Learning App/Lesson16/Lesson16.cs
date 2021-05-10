using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learning_App.Lesson16.HomeWorkTaskWithDictionary;
using Learning_App.Lesson16.MyIO;
using Learning_App.Lesson16.StringTask;

namespace Learning_App.Lesson16
{
    class Lesson16
    {
        static void Main()
        {
            TaskWithDictionary dictionaryTask = new TaskWithDictionary();

            dictionaryTask.TaskDictionary();

        }

        private void LessonTaskIO()
        {
            LessonTaskMyIO myIO = new LessonTaskMyIO();
            myIO.TaskWithIO();
        }

        private void Lesson15()
        {
            TaskString n = new TaskString();
            n.TestStringTask();
        }
    }
}
