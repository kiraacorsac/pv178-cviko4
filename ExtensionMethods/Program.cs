﻿using System;

namespace ExtensionMethods
{
    /// <summary>
    /// Ukol: Implementace rozsirujicich metod
    /// 
    /// I. Implementace tridy ExtensionMethods
    /// 
    /// II. Spusteni projektu (kontrolni vypis)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var sampleLine = "Hello world!";
            var wordCount = sampleLine.CountWordsWithinLine();
            Console.WriteLine($"Line: {sampleLine} has {wordCount} words.");
            Console.WriteLine();
            Console.ReadKey();

            var sampleWord = "Coolermaster";
            var first4Chars = sampleWord.GetFirstFourChars();
            Console.WriteLine($"First 4 chars of: {sampleWord} are {first4Chars}");
            Console.WriteLine();
            Console.ReadKey();

            const int element = 3;
            var numbers = new[] { 1, 3, 7, 3, 5, 2, 3, 4, 8, 3, 9 };
            var occurencesOfElement = numbers.CountOccurancesOfElement(element);
            Console.WriteLine($"Element: {element} has occured {occurencesOfElement}x times");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
