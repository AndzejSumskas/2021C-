using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson6
{
    class ArrayDouble
    {
        static void Main()
        {
            
        }


        static void MasyvasMasyve()
        {
            int[][] ArrayInArray;
            ArrayInArray = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[]{11,22,33,44,55},
                new int[]{111,222,333,444,555}
            };

            Console.WriteLine(ArrayInArray[0][4]);
            ArrayInArray[0][4] = 698;
            Console.WriteLine(ArrayInArray[0][4]);

            int[][] jiggedArray = new int[10][];
            for (int i = 0; i < 10; i++)
            {
                jiggedArray[i] = new int[5];
            }

            jiggedArray[0][4] = 5665;

        }

        static void DvimatisMasyvas()
        {
            string[,] names;

            int[,] numbers = new int[4, 4]
            {
                {1,2,3,4 },
                {5,6,7,8 },
                {9,10,11,12 },
                {13,14,15,16 }
            };

            Console.WriteLine(numbers[2, 2]);
        }
    }
}
