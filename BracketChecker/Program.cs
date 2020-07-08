using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> BracketList = new List<string>
            {
                "{}", "{[]}", "({([])})", "{[])", "{{{", "{)"
            };

            foreach (var bracket in BracketList)
            {
                Console.WriteLine(string.Concat(bracket, ": ", CheckBrackets.IsBalanced(bracket) ? "CORRECT" : "INCORRECT"));
            }

            Console.ReadKey();
        }
    }
}
