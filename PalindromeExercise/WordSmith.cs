using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsAPalindrome(string word)
        {
            if (word.ToLower()=="palindrome")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}

