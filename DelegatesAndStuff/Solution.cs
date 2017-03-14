using System;
using System.Collections.Generic;

namespace AnonymousLambdaDelegate
{
    public static class Solution
    {
        public static void TestAll()
        {
            //Protyp: pouzivajte lambda funkcie je to rychlejsie a krajsie

            var numbersToSort = new[] { 0, 1, 3, 12, 8, 7, 43, 18, 93, 26, 57 };

            //TODO pridajte do funkcie QuickSort delegata ktory vypise parametre na konzolu
            Solution.QuickSort(numbersToSort, 0, numbersToSort.Length-1, (index, pivot) => Console.WriteLine($"Pivot log> element: {pivot} on index: {index}"));
            Console.WriteLine(string.Join(",", numbersToSort));
            Console.ReadKey();

            //TODO: Vypiste kazdy prvok na novy riadok konzoly
            List<string> collection = new List<string> { "these", "are", "some", "elements" };
            collection.ForEach(Console.WriteLine);
            Console.ReadKey();

            var numbersToFilter = new[] { 0, 1, 3, 12, 8, 7, 43, 18, 93, 26, 57 };
            numbersToFilter.Where(s=> s < 15).ForEach(Console.WriteLine);
            Console.ReadKey();

            var upper = "This is argument".Apply( s => s.ToUpper() );
            Console.WriteLine(upper);
            Console.ReadKey();
        }


        private static Random random = new Random();

        /// <summary>
        /// Algoritmus triedi cisla metodou quicksort.Merie delegata ktory sa stara o logovanie
        /// </summary>
        /// <param name="numbersToSort">Vstupna sekvencia</param>
        /// <param name="start">prvy index triedenej postupnosti</param>
        /// <param name="end">posledny index triedenej postupnosti</param>
        /// <param name="logAction">Dorobit</param>
        public static void QuickSort(int[] numbersToSort, int start, int end, Action<int, int> logAction = null)
        {
            if (start >= end)
            {
                return;
            }

            int randomIndex = random.Next(start, end-1);
            int pivot = numbersToSort[randomIndex];

            //TODO vypis do konzoly uprostred algoritmu je nevhodny pridajte funkcii optional parameter delegat "logAction" ktory sa postara o vypis. 
            //TODO: Delegat spracuje parametre randomIndex, pivot
            logAction?.Invoke(randomIndex, pivot);

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && numbersToSort[j] >= pivot)
                {
                    j--;
                }

                numbersToSort[i] = numbersToSort[j];

                while (i < j && numbersToSort[i] < pivot)
                {
                    i++;
                }

                numbersToSort[j] = numbersToSort[i];
            }

            numbersToSort[i] = pivot;
            QuickSort(numbersToSort, start, i - 1, logAction);
            QuickSort(numbersToSort, i + 1, end, logAction);
        }

        /// <summary>
        /// Rozsiruje IEnumerable
        /// Vykona akciu na kazdom elenete IEnumerable elementov typu T
        /// </summary>
        /// <typeparam name="T">Typ elementu kolekcie</typeparam>
        /// <param name="collection">Kolekcia IEnumerable</param>
        /// <param name="action">Akcia ktora sa ma vykonat pre kazdy element kolekcie</param>
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var element in collection)
            {
                action(element);
            }
        }

        /// <summary>
        /// Rozsiruje IEnumerable
        /// Vyfiltruje elementy kolekcie podla zadanej podmienky
        /// </summary>
        /// <typeparam name="T">Typ elementu kolekcie</typeparam>
        /// <param name="collection">Kolekcia IEnumerable</param>
        /// <param name="condition">Podmienka ktoru musia vysledne elementy splnat (Func)</param>
        /// <returns>Kolekcia prvkou ktore splnaju zadanu podmienku</returns>
        public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            foreach (var element in collection)
            {
                if (condition(element))
                {
                    yield return element;
                }
            }
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
        public static TResult Apply<TTarget, TResult>( this TTarget target, Func<TTarget, TResult> outerFunction)
        {
            return outerFunction(target);
        }
    }
}
