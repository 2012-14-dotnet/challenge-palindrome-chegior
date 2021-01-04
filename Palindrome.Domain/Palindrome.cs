namespace  Palindrome.Domain
{
    public class CPalindrome
    {
        public string InputWord { get; set; }
        public char[] ArrayTemp { get; set; }

        public void CleanUpWordOrPhrase(string Input)
        {
            InputWord = Input.Trim().ToLower();
            System.Console.WriteLine("Your clean input is:'{0}'",InputWord);
        }
    }
}