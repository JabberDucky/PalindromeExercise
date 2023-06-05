using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var backwards = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                backwards += word[i];
            }
            if (backwards == word)
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
