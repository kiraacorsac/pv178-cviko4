using System;
using System.Collections.Generic;
using ExtensionMethods;

namespace DelegatesAndStuff
{
    /// <summary>
    /// Ukol: Prace s lambda vyrazy
    /// 
    /// I. Implementace lambda vyrazu v
    ///    nize uvedenych testovacich 
    ///    metodach, veskere info je v 
    ///    prislusnych popiscich
    /// 
    /// II. Dokonceni implementace tridy 
    ///     Utils, vsechny mista jsou 
    ///     oznaceny (TODO)
    /// 
    /// III. spusteni projektu
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Protyp: pouzivajte lambda funkcie je to rychlejsie a krajsie

            var numbersToSort = new[] { 0, 1, 3, 12, 8, 7, 43, 18, 93, 26, 57 };

            //TODO pridajte do funkcie QuickSort delegata ktory vypise parametre na konzolu
            Utils.QuickSort(numbersToSort, 0, numbersToSort.Length);
            Console.WriteLine(string.Join(",", numbersToSort));
            Console.ReadKey();

            //TODO: Vypiste kazdy prvok na novy riadok konzoly
            List<string> collection = new List<string> { "these", "are", "some", "elements" };
            //collection.ForEach(... );
            Console.ReadKey();

            var numbersToFilter = new[] { 0, 1, 3, 12, 8, 7, 43, 18, 93, 26, 57 };
            //TODO - pomocou naimplementovanej funkcie where a foreach vypiste na konzolu len cisla > 15 
            Console.ReadKey();

            //TODO: Odkomentujte v pripade bonusu
            //var upper = "This is argument".Apply( s => s.ToUpper() );
            //Console.WriteLine(upper);
            //Console.ReadKey();
        }
    }
}