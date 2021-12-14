﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4. 5. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:

           1 0 1 0 1

           0 1 0 1 0

           1 0 1 0 1

           0 1 0 1 0

           1 0 1 0 1
           */
            Console.WriteLine("Введите количество N строк и столбцов массива ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[N, N];


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = 1 - (i + j) % 2;
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
