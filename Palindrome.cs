using System;

namespace Week14Repetition.Practice
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            if (IsPalindrome(word))
            {
                Console.WriteLine($"'{word}' is a palindrome");
            }
            else
            {
                Console.WriteLine($"'{word}' is not a palindrome");
            }
        }

        private static bool IsPalindrome(string word)
        {
            int stop = word.Length / 2;
            
            for (int i = 0; i < stop; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
