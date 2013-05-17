using System;
using System.Linq;

namespace _5.StringArraySort
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of elements in the array: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            string[] Arr = new string[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("A[{0}] = " , i);
                Arr[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Array.Sort(Arr, (x, y) => (x.Length).CompareTo(y.Length));
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("A[{0}] = {1}" , i , Arr[i]);
            }
        }
    }
}
