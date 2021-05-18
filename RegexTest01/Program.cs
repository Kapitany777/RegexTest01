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
        private static void Example1()
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

        private static void Example2()
        {
            string text = "pista.bacsi@lidercfeny.hu";
            string pattern = @"@.+.\.hu$";

            if (Regex.IsMatch(text, pattern))
            {
                Console.WriteLine("Match found");
            }
        }

        private static void Example3()
        {
            string text = "pista.bacsi@lidercfeny.hu;feri.bacsi@zombiapokalipszis.hu";
            string pattern = @"@[a-z]+\.hu";

            foreach (var match in Regex.Matches(text, pattern))
            {
                Console.WriteLine(match);
            }
        }

        private static void Example4()
        {
            string text = "abc12345x";
            string pattern = @"\d+";

            Regex regex = new Regex(pattern);

            Console.WriteLine(regex.IsMatch(text));
            Console.WriteLine(regex.Match(text));
        }

        private static void Example5()
        {
            string text = "The Good Old PISTA";
            string pattern = @"Old\sp\w{1,3}a";

            Console.WriteLine(Regex.Match(text, pattern, RegexOptions.IgnoreCase));
        }

        private static void Example6()
        {
            string patternIpAddress = @"^(\d{1,3}\.){3}\d{1,3}$";  // Not perfect, produces false positives
            var regex = new Regex(patternIpAddress);

            string validIpAddress = "192.168.88.15";
            var match1 = regex.Match(validIpAddress);

            if (match1.Success)
            {
                Console.WriteLine($"{validIpAddress} is a valid IP address");
                Console.WriteLine(match1.Value);

                validIpAddress
                    .Split('.')
                    .ToList()
                    .ForEach(octet => Console.WriteLine(octet));

                Console.WriteLine();
            }

            string invalidIpAddress = "192.168.";
            var match2 = regex.Match(invalidIpAddress);

            if (!match2.Success)
            {
                Console.WriteLine($"{invalidIpAddress} is an invalid IP address");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Example 1");
            Example1();
            Console.WriteLine();

            Console.WriteLine("Example 2");
            Example2();
            Console.WriteLine();

            Console.WriteLine("Example 3");
            Example3();
            Console.WriteLine();

            Console.WriteLine("Example 4");
            Example4();
            Console.WriteLine();

            Console.WriteLine("Example 5");
            Example5();
            Console.WriteLine();

            Console.WriteLine("Example 6");
            Example6();
            Console.WriteLine();
        }
    }
}
