using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Moderate_Problems_CSharp
{
    //https://www.codeeval.com/open_challenges/13/
    public class CharacterRemover
    {
        //Write a program which removes specific characters from a string.
        public static string RemoveInputCharactersFromString(string str, string charactersToRemove)
        {
            if (string.IsNullOrEmpty(str))
                return null;
            var sb = new StringBuilder();
            foreach (var c in str.Where(c => !charactersToRemove.Contains(c)))
            {
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static string RemoveInputCharactersFromString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;
            var sb = new StringBuilder();
            var splittedContent = str.Split(',');

            foreach (var c in splittedContent[0].Where(c => !splittedContent[1].Substring(1).Contains(c)))
            {
                sb.Append(c);
            }
            return sb.ToString();
        }

    }
}
