using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketChecker
{
    public static class CheckBrackets
    {
        /// <summary>
        /// Checks if input string has correct bracket opening/closing
        /// </summary>
        /// <returns>True for correct bracket input and false for incorrect bracket input</returns>
        public static bool IsBalanced(string s)
        {
            Dictionary<char, char> brackets = new Dictionary<char, char> { { '{', '}' }, { '[', ']' }, { '(', ')' } };
            //List of all open brackets in order to check against any closing brackets
            List<char> openBrackets = new List<char>();

            foreach (var c in s)
            {
                if (brackets.ContainsKey(c))
                {
                    openBrackets.Add(c);
                }
                else if (openBrackets.Any() && c == brackets[openBrackets.Last()])
                {
                    //Opening bracket has correct closing bracket so remove it from list
                    openBrackets.RemoveAt(openBrackets.Count - 1);
                }
                else
                {
                    return false;
                }
            }

            //Open bracket without closing bracket in string
            if (openBrackets.Any())
            {
                return false;
            }

            return true;
        }
    }
}
