﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR Ciklas   //i, j , m, n

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 5; i < 50; i+=5)
            //{
            //    Console.WriteLine(i);
            //}

            //Uzduotis 1

            //for (int i = 0; i < 20; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Uzduotis 2

            //Console.WriteLine("Iveskite rezius");
            //int sk1 = Convert.ToInt32(Console.ReadLine());
            //int sk2 = Convert.ToInt32(Console.ReadLine());

            //if (sk1 >= sk2) 
            //{ 
            //    Console.WriteLine("Bad limits!"); 
            //}
            //else
            //{
            //    for (int i = sk1; i < sk2; i++)
            //    {
            //        Console.WriteLine($"{i} {i * i}");
            //    }
            //}

            //Uzduotis 3

            //int suma = 0;

            //for (int i = 1000; i > 0; i--)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        suma += i;
            //    }             
            //}
            //Console.WriteLine("Suma = {0}", suma);

            //************************************************

            //While ciklas

            //Uzduotis

            //Console.WriteLine("Pasirinkite: \n1 Kava \n2 Arbata \n3 Vanduo");
            //int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            //while (pasirinkimas > 3 || pasirinkimas < 1) 
            //{
            //    Console.WriteLine("Klaidinga ivestis");
            //    Console.WriteLine("Pasirinkite: \n1 Kava \n2 Arbata \n3 Vanduo");
            //    pasirinkimas = Convert.ToInt32(Console.ReadLine());
            //}
            //switch(pasirinkimas)
            //{
            //    case 1:
            //      Console.WriteLine("Kava");
            //        break;
            //    case 2:
            //        Console.WriteLine("Arbata");
            //        break;
            //    case 3:
            //        Console.WriteLine("Vanduo");
            //        break;
            //}

            //Do while ciklas

            //int input;
            //do
            //{
            //    Console.WriteLine("Pasirinkite: \n1 Kava \n2 Arbata \n3 Vanduo");
            //    input = Convert.ToInt32(Console.ReadLine());
            //}
            //while (input < 1 || input > 3);

            //int vietuPrieLango = 4;
            //int vietuSkaicius = 8;

            //while (vietuPrieLango > 0 || vietuSkaicius > 0)
            //{
            //    Console.WriteLine("Ar norite sedeti prie lango? t/n");
            //    char pasirinkimas = Convert.ToChar(Console.ReadLine());
            //    switch (pasirinkimas)
            //    {
            //        case 't':
            //            vietuPrieLango--;
            //            vietuSkaicius--;
            //            break;
            //        case 'n':
            //            vietuSkaicius--;
            //            break;
            //        default:
            //            Console.WriteLine("Klaida");
            //            break;
            //    }



            //    do
            //    {
            //        Console.WriteLine("Ar norite sedeti prie lango? t/n");
            //        pasirinkimas = Convert.ToChar(Console.ReadLine());
            //        switch (pasirinkimas)
            //        {
            //            case 't':
            //                vietuPrieLango--;
            //                vietuSkaicius--;
            //                break;
            //            case 'n':
            //                vietuSkaicius--;
            //                break;
            //            default:
            //                Console.WriteLine("Klaida");
            //                break;
            //        }
            //    } while (vietuPrieLango > 0 && vietuSkaicius > 0);

            //********************************************************

            //const int totalseetcount = 8;
            //const int windowseetcount = 4;
            //int allseetstaken = 0;
            //int windowseetstaken = 0;
            //string choise;

           

            //while (allseetstaken < totalseetcount || windowseetstaken < windowseetcount)
            //{
            //    do
            //    {
            //        Console.WriteLine("Ar norite sedeti prie lango? [yes/no]");
            //        choise = Convert.ToString(Console.ReadLine());
            //    } while (choise != "yes" && choise != "no");

            //    if (choise == "yes")
            //    {
            //        windowseetstaken++;   
            //    }
            //    allseetstaken++;


            //}
            //*******************************************

            //int suma = 0;
            //for (int i = 0; i < 1000; i++)
            //{

            //    if (i % 5 == 0) 
            //    {
            //        continue;
            //    }               
            //    if (i > 123)
            //    {
            //        break;
            //    }
            //    suma += i;
            //}
            //Console.WriteLine(suma);

            //int sumaj = 0;
            //int j = 0;

            //for (;;)
            //{

            //    if (j % 5 == 0)
            //    {
            //        j++;
            //        continue;
            //    }
            //    if (j > 123)
            //    {
            //        break;
            //    }
            //    sumaj += j;
            //    j++;
            //}
            //Console.WriteLine("j" + sumaj);
        }
    }
}


