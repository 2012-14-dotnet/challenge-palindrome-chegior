using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CPalindrome PalindromeInst = new CPalindrome();
            string opt = " ";
            Console.Clear();
            Console.WriteLine("+++Welcome to Palindrome");
            while(opt!="4")
            {
                MainMenuUser();
                switch (opt = Console.ReadLine())
                {
                    case "1":Console.WriteLine("1"); break;
                    case "2":Console.WriteLine("2");break;
                    case "3":Console.WriteLine("3");break;
                    case "4":Console.WriteLine("4");break;
                    default:System.Console.WriteLine("Sorry I dont have that option for now....");break;
                }
            }

            // Console.Write("Pleae type your word or phrase: ");
            // PalindromeInst.CleanUpWordOrPhrase(Console.ReadLine());
        }
        static void MainMenuUser()
        {
            System.Console.WriteLine("Type a Key to Continue.....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("+++++++++MAIN MENU+++++++");
            Console.WriteLine("Please Enter your Selection");
            Console.WriteLine("1.- Enter a Word or Phrase to check Palindrome");
            Console.WriteLine("2.- Run Tests");
            Console.WriteLine("3.- What's Palindrome");
            Console.WriteLine("4.- Exit");
            
        }
    }
}
