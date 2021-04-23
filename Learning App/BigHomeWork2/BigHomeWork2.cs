using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.BigHomeWork2
{
    class BigHomeWork2
    {
        static void Main()
        {
            CreateMagicNumberSixdigit(2);
            CreateMagicNumberSixdigit(3);
            CreateMagicNumberSixdigit(4);
            CreateMagicNumberSixdigit(5);
            CreateMagicNumberSixdigit(6);
        }

        static void CreateMagicNumberSixdigit(int nr)
        {
            int maxNumber = 987654 ;
            int minNumber = 123456;
            int[] array = new int[6];
            int[] array2 = new int[6];

            for (int i = minNumber; i < maxNumber; i++)
            {
                if (i * nr <= maxNumber) 
                {
                    NumberToArray(i, array);
                    NumberToArray(i * nr, array2);
                                      
                    if (MagicNumberIsGood(array)&& MagicNumberIsGood(array2))
                    {
                        if (TwoMagicNumbersChech(array, array2))
                        {
                            Console.Write("Magic number is: ");
                            foreach (var item in array)
                            {
                                Console.Write(item);
                            }
                            Console.WriteLine();
                            Console.Write($"Magic number*{nr} is: ");
                            
                            foreach (var item in array2)
                            {
                                Console.Write(item);
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
        static void NumberToArray(int largeNumber, int[] array)
        {
            int tempNumber = 100000;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = largeNumber / tempNumber;
                largeNumber = largeNumber % tempNumber;
                tempNumber /= 10;
            }          
        }

        static bool MagicNumberIsGood(int[] array)
        {
            int uniqueNumber = 0;
            int number = 1;
            foreach (int num in array)
            {
                for (int i = number; i < array.Length; i++)
                {
                    if (num == array[i])
                    {
                        return false;
                    }
                }
                uniqueNumber++;
                number++;       
            }
            return true;
        }

        static bool TwoMagicNumbersChech(int[] array, int[] array2)
        {
            bool tempBool = true;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        tempBool = true;
                        break;
                    }
                    tempBool = false;
                }
                if(tempBool == false)
                {
                    return false;
                }

            }
            return tempBool;
        }

        static void Test()
        {
            int skaicius = 123465;

            int skaicius2 = 235491;
            Random rnd = new Random();

            int[] masyvas = new int[6];
            int[] masyvas2 = new int[6];

            int[] masyvas3 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] masyvas4 = new int[] { 2, 3, 4, 5, 6, 1 };

            NumberToArray(skaicius, masyvas);
            NumberToArray(skaicius2, masyvas2);

            Console.WriteLine(TwoMagicNumbersChech(masyvas, masyvas2));
            Console.WriteLine(TwoMagicNumbersChech(masyvas3, masyvas4));


            //Console.WriteLine(MagicNumberIsGood(masyvas));

        }
    }
}
