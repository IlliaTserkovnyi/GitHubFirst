using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                string originalWord = Console.ReadLine();
                Console.WriteLine($"Is word {originalWord} palindrome? True/False \n" + IsPalindrom(originalWord) + "\n---------");
                Console.WriteLine("Try again? 1 - Yes. 2 - No.");
                flag = Console.ReadLine() == "1";
            }
        }

        static bool IsPalindrom(string word)
        {
            return word == new string(word.Reverse().ToArray());
        }
    }
}
