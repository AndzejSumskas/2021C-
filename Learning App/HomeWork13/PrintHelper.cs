using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson13.PrintHelper
{
    static class PrintHelper
    {
        public static string Message;

        public static void Print(string message, params object[] args)
        {
            Message = message;
            Console.Write(Message + ": ");

            for (int i = 0; i < args.Length; i++)
            {
                if(i == args.Length-1)
                {
                    Console.Write(Convert.ToString(args[i]) + ". ");
                    break;
                }
                Console.Write(Convert.ToString(args[i]) + ", ");
            }      
        }

        public static void PrintTable(params object[] args)
        {
            
            foreach (var item in args)
            {
                Type type = item.GetType();

                if (type.Equals(typeof(int)))
                {
                    Console.WriteLine("Int " + item);
                }
                else if (type.Equals(typeof(double)))
                {
                    Console.WriteLine("Double " + item);
                }
                else if (type.Equals(typeof(string)))
                {
                    Console.WriteLine("String " + item);
                }
                else if (type.Equals(typeof(char)))
                {
                    Console.WriteLine("Char " + item);
                }
            }

        }

        
    }
}
