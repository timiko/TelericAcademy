using System;

namespace _4.BinSearchArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of elements in the array: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter the number K: ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] Arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("A[{0}] = " , i);
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Array.Sort(Arr);
            int final_Number = Array.BinarySearch(Arr, K);
            if (~final_Number == 0)
            {
                Console.Write("There is no such number!");
            }
            else if (final_Number < 0)
            {
                Console.Write("The largest number <= to {0} is {1}.", K, Arr[~final_Number - 1]);
            }
            else if (final_Number >= 0)
            {
                Console.Write("The largest number <= to {0} is {1}.", K, Arr[final_Number]);
            }
        }
    }
}
