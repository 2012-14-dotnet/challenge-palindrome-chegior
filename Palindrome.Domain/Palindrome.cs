using System;

namespace  Palindrome.Domain
{
    public class CPalindrome
    {
        public string InputWord { get; set; }
        public string ReverseWord { get; set; }
        public string[] ArrayTemp { get; set; }

        public void CleanUpWordOrPhrase(string Input)
        {
            
            InputWord = Input.Trim().ToLower();
            System.Console.WriteLine("Your clean input is:'{0}'",InputWord);
            RemoveSpacesOrSpecialChar(InputWord);
            ReverseWordOrPhrase(InputWord);
            System.Console.WriteLine(AreTheyPalindrome());
        }

        private void ReverseWordOrPhrase(string inputWord)
        {
            char[] charArray = inputWord.ToCharArray();
            Array.Reverse( charArray );
            ReverseWord = new string( charArray );
            System.Console.WriteLine(ReverseWord);
        }

        public void RemoveSpacesOrSpecialChar(string Input){
            char[] delimetersNoise = { ' ',';','.',':','\t'};
            ArrayTemp = Input.Split(delimetersNoise);
            foreach ( var word in ArrayTemp)
            {
                System.Console.WriteLine("Your Temp Array: {0}",word);     
            }
            
        }
        public bool AreTheyPalindrome()
        {
            return InputWord.Equals(ReverseWord);
        }
    }
}