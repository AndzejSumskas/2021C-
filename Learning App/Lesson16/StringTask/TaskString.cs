using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson16.StringTask
{
    public class TaskString
    {
        

        public void TestStringTask()
        {
            TaskOne();
            TaskTwo();
        }

        private void TaskTwo()
        {
            StringBuilder myString = new StringBuilder("Tekstas textas textasTekstas textas textasTekstas t\nextas textasTekstas textas textasTekstas textas \ntextasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textasTekstas textas textas");
            int number = myString.Length;
            Console.WriteLine(number);
            myString.Append("Zinute zinute zinuteZinute zinute zinuteZinute zinute zinu\nteZinute zinute zinuteZinute zinute zinuteZinute zinute zinuteZinute zinute zinuteZinute zi\nnute zinute");
            myString.AppendLine("Voice messageVoice messageVoice messageVoice messageVoice messageVoice message");
            Console.WriteLine(myString);
            myString.AppendFormat("zinute", "Sz");
            Console.WriteLine("*************************************");

            myString.Insert(25, "MMMMMMMMMMMMMMM");
            Console.WriteLine(myString);

            myString.Replace('a', 'A');
            Console.WriteLine(myString);
            Console.WriteLine("*************************************");
            myString.Remove(25, 50);
            Console.WriteLine(myString);
            //myString.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine(myString);

            string tectCopy;
            char[] array = new char[100];

            myString.CopyTo(0, array, 0, 69);
            Console.WriteLine("*************************************");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("*************************************");

            array.ToString();

            Console.WriteLine(array);


        }

        private void TaskOne()
        {
            string test = "Volkeris Texsaso Rendzeris";

            char testChar = test[2];
            char testChar2 = 'P';

            Console.WriteLine(test);
            Console.WriteLine(testChar);

            int testLenght = test.Length;

            Console.WriteLine(testLenght);

            string testCut = test.Substring(0, 10);

            string personazas = "personazai";

            Console.WriteLine(string.Format("Tomas ir Dzeris yra {0}.", personazas));
            Console.WriteLine(personazas);
            Console.WriteLine(personazas.Remove(2, 6));
            personazas.Remove(2, 6);
            Console.WriteLine(personazas);
            Console.WriteLine(personazas.Replace(personazas[0], testChar2));
            personazas.Replace(testChar, testChar2);
            Console.WriteLine(personazas);
        }
    }
}
