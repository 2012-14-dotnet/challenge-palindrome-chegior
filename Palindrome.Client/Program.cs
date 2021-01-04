using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CPalindrome PalindromeInst = new CPalindrome();
            Console.WriteLine("+++Welcome to Palindrome");
            
            Console.Write("Pleae type your word or phrase: ");
            PalindromeInst.CleanUpWordOrPhrase(Console.ReadLine());
        }
    }
}
