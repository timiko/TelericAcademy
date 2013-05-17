using System;

namespace _2.SumOfSubArray3x3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array (minimal size 3): ");
            int N = int.Parse(Console.ReadLine());
            int[,] Arr = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("A[{0} , {1}] = ", i , j);
                    Arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int sum = 0;
            int max_sum = 0;
            for (int i = 1; i < N - 1; i++)
            {
                for (int j = 1; j < N - 1; j++)
                {
                    sum = Arr[i, j] + Arr[i, j + 1] + Arr[i, j - 1] + Arr[i + 1, j] + Arr[i - 1, j] + Arr[i + 1, j + 1] + Arr[i + 1, j - 1] + Arr[i - 1, j + 1] + Arr[i - 1, j - 1];
                    if (max_sum < sum)
                    {
                        max_sum = sum;
                    }
                }
            }
            Console.WriteLine("The maximal sum is: {0}" , max_sum);
        }
    }
}
