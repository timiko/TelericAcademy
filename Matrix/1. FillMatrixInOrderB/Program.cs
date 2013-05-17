﻿using System;

namespace _1.FillMatrixInOrderB
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the matrix: ");
            int N = int.Parse(Console.ReadLine());
            int[,] Arr = new int[N, N];
            int counter = 1;
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Arr[j, i] = counter++;
                    }
                }
                else
                {
                    for (int j = N - 1; j >= 0; j--)
                    {
                        Arr[j, i] = counter++;
                    }
                }

            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", Arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
