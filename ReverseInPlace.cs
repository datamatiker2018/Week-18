using System;

namespace Week14Repetition.Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 2, 3 };

            Console.WriteLine(string.Join(", ", a));
            
            for (int i = 0; i < a.Length / 2; i++)
            {
                int swapIndex = a.Length - 1 - i;
                int temporary = a[i];
                a[i] = a[swapIndex];
                a[swapIndex] = temporary;
            }

            Console.WriteLine(string.Join(", ", a));
        }
    }
}
