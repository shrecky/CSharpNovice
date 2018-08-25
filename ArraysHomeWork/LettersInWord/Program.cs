using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] letters = new int[26];
            for (char i = 'A'; i <= 'Z'; i++) letters[i - 65] = i;

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
                Console.WriteLine("Letter '{0}' -> index: {1} / ASCII Index: {2}", word[i],
                    Array.IndexOf(letters, char.ToUpperInvariant(word[i])), (int)word[i]);
        }
    }
}
