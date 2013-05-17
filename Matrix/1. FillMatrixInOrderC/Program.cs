using System;

namespace _1.FillMatrixInOrderC
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the matrix: ");
            int N = int.Parse(Console.ReadLine());
            int[,] Arr = new int[N, N];
            int counter = 1;
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j < N - i; j++)
                {
                    Arr[i + j, j] = counter++;
                }
            }
            for (int j = 1; j < N; j++)
            {
                for (int i = 0; i < N - j; i++)
                {
                    Arr[i, i + j] = counter++;
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
