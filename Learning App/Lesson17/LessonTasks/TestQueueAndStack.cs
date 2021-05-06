using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson17.LessonTasks
{
    public class TestQueueAndStack
    {
        public static void SecondTask()
        {
            Queue<string> eile = new Queue<string>();

            eile.Enqueue("Vienas");
            eile.Enqueue("du");
            eile.Enqueue("trys");
            eile.Enqueue("keturi");
            eile.Enqueue("penki");
            eile.Enqueue("sesi");

            Console.WriteLine(  eile.Count);


            //Istryna siuo atveju "Vienas"
            eile.Dequeue();

            Console.WriteLine(eile.Count);

            Console.WriteLine(eile.Peek());


            Console.WriteLine(eile.Contains("trys"));


            string[] arrayQueue = eile.ToArray();

            Console.WriteLine("*-***");
            foreach (var item in eile)
            {
                Console.WriteLine(item);
            }

            Stack<string> kruva = new Stack<string>();


            kruva.Push("Tomas");
            kruva.Push("Toma");
            kruva.Push("Marius");
            kruva.Push("ds");
            kruva.Push("gh");

            Console.WriteLine("Count");

            Console.WriteLine(kruva.Count);
            //pasalina paskutini
            Console.WriteLine(kruva.Pop());
            Console.WriteLine("Foreach");
            foreach (var item in kruva)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(kruva.Peek());
            Console.WriteLine(kruva.Peek());



        }
    }
}
