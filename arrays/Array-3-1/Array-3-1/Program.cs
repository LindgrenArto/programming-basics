﻿using System;

namespace Array_3_1
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa 10:n numeron taulukkoon numerot 0-20 väliltä.");
            string[] x = new string[10];            

            for (int i = 0; i < 10; i++)
            {
                x[i] = Sorter();
                Console.WriteLine($"{i + 1} = {x[i]}");
            }
            Console.ReadKey();
        }
        static string Sorter()
        {          
            int y = rnd.Next(1, 21);
            string res = "";
 
               if (y < 10)
               {
                    res = "0" + y.ToString();
               }
               else
               {
                    res = y.ToString();
               }
               return res;
   
        }
    }
}
