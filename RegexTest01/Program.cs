using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest01
{
    class Program
    {
        static void Example1()
        {
            string text = "pista.bacsi@lidercfeny.hu";
            string pattern = @"@.+.\.hu$";

            Match match = Regex.Match(text, pattern);

            if (match.Success)
            {
                Console.WriteLine($"Index:    {match.Index}");
                Console.WriteLine($"Length:   {match.Length}");
                Console.WriteLine($"Value:    {match.Value}");
                Console.WriteLine($"ToString: {match.ToString()}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Example 1");
            Example1();
            Console.WriteLine();
        }
    }
}
