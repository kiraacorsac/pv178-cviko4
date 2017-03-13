using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    public static class Utils
    {
        public static void PrintRepeatedly(/* TODO - add parameter */)
        {
            const int repetitionCount = 3;
            const string content = " <-> ";
            Console.WriteLine($"Following content:{content}will be printed repeatedly ({repetitionCount}x times):");

            // TODO - Ivoke delegate passed as parameter...
            // ...
            
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }

        public static void CheckPalindromes(/* TODO - add parameter */)
        {
            var palindromes = new List<string>();
            var words = new[]
            {
                "civic",
                "disco",
                "level",
                "numb",
                "racecar",
                "rear",
                "redder",
            };
            Console.WriteLine("Given words:");
            foreach (var word in words)
            {
                Console.Write($"{word}, ");
            }

            foreach (var word in words)
            {
                // TODO - Ivoke delegate passed as parameter...
                // var isPalindrome = ...

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(Environment.NewLine + "Palindromes:");
            foreach (var palindrome in palindromes)
            {
                Console.Write($"{palindrome}, ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }

        public static void PrintGreaterThanLimit(/* TODO - add parameter */)
        {
            const int limit = 15;
            var numbers = new[] { 0, 1, 3, 12, 8, 7, 43, 18, 93, 26, 57 };
            Console.WriteLine("Given numbers:");
            foreach (var number in numbers)
            {
                Console.Write($"{number}, ");
            }

            // TODO - Ivoke delegate passed as parameter...
            // var filteredNumbers = ...

            Console.WriteLine(Environment.NewLine + $"Numbers greater than {limit}:");
            foreach (var number in filteredNumbers)
            {
                Console.Write($"{number}, ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.ReadKey();
        }

        /// <summary>
        /// Rozsiruje IEnumerable
        /// Vykona akciu na kazdom elenete IEnumerable
        /// </summary>
        /// <typeparam name="T">Typ elementu kolekcie</typeparam>
        /// <param name="collection">Kolekcia IEnumerable</param>
        /// <param name="action">Akcia ktora sa ma vykonat pre kazdy element kolekcie</param>
        public static void ForEach</*TODO*/>( /*TODO parametre*/)
        {
            //TODO
        }

        /// <summary>
        /// Bonus:
        /// Aplikuje outerFunction: outer(a) na a. funguje ako operator "po" v matematike f(g()) = g() po f().
        /// </summary>
        /// <typeparam name="TTarget">Typ argumentu vonkajsej funkcie</typeparam>
        /// <typeparam name="TResult">Typ vysledku vonkajsej funkcie</typeparam>
        /// <param name="target">ciel na ktoru chceme funkciu aplikovat</param>
        /// <param name="outerFunction">Funkcia ktoru chceme aplikovat</param>
        /// <returns></returns>
        public static TResult Apply<TTarget, TResult>( /*TODO parameters*/)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
