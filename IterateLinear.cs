using System;

namespace Week14Repetition.Iteration
{
    class Program
    {
        static void Main()
        {
            int[] a = { 1, 1, 2, 3 };
    
            foreach (int n in a)
            {
                Console.Write($"{n} ");
            }
            
            Console.WriteLine();
            
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write($"{a[i]} ");
            }

            Console.WriteLine();

            int[] b = new int[4];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[a.Length - 1 - i];
            }

            foreach (int n in b)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
