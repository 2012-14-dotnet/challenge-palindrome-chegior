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
                    case "1":Console.WriteLine("Lets enter the input....");Option1Menu(PalindromeInst); break;
                    case "2":Console.WriteLine("2");Option2Menu();break;
                    case "3":Console.WriteLine("3");Option3Menu();break;
                    case "4":Console.WriteLine("4");Option4Menu();break;
                    default:System.Console.WriteLine("Sorry I dont have that option for now....");break;
                }
            }

            // 
        }

        private static void Option4Menu()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using Palindrome Program .....bye now!!!   :).");
            System.Console.WriteLine("Type a Key to Continue.....");
            Console.ReadKey();
        }

        private static void Option3Menu()
        {
            Console.Clear();
            Console.WriteLine("Whats a Palindrome");
            Console.WriteLine("A word, phrase, or sequence that reads the same backward as forward, e.g., madam or nurses run.");
            //System.Console.WriteLine("Type a Key to Continue.....");
            Console.ReadKey();
        }

        private static void Option2Menu()
        {
            Console.WriteLine("Sorry....No TEST for now :( ");
            // System.Console.WriteLine("Type a Key to Continue.....");
            Console.ReadKey();
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

        static void Option1Menu(CPalindrome cp)
        {
            Console.Write("Pleae type your word or phrase: ");
            cp.CleanUpWordOrPhrase(Console.ReadLine());
        }
    }
}
