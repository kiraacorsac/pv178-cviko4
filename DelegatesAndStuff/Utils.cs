using System;
using System.Collections.Generic;

namespace ExtensionMethods
{



    public static class Utils
    {
        private static Random random = new Random();

        /// <summary>
        /// Algoritmus triedi cisla metodou quicksort.Merie delegata ktory sa stara o logovanie
        /// </summary>
        /// <param name="numbersToSort">Vstupna sekvencia</param>
        /// <param name="start">prvy index triedenej postupnosti</param>
        /// <param name="end">posledny index triedenej postupnosti</param>
        public static void QuickSort(int[] numbersToSort, int start, int end /*TODO */)
        {
            if (start >= end)
            {
                return;
            }

            int randomIndex = random.Next(start, end);
            int pivot = numbersToSort[randomIndex];

            //TODO vypis do konzoly uprostred algoritmu je nevhodny pridajte funkcii optional parameter delegat "logAction" ktory sa postara o vypis. 
            //TODO: Delegat spracuje parametre randomIndex, pivot
            Console.WriteLine($"Pivot is on position {randomIndex} element: {pivot}");

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && numbersToSort[j] > pivot)
                {
                    j--;
                }

                numbersToSort[i] = numbersToSort[j];

                while (i < j && numbersToSort[i] <= pivot)
                {
                    i++;
                }

                numbersToSort[j] = numbersToSort[i];
            }

            numbersToSort[i] = pivot;
            QuickSort(numbersToSort, start, i - 1 /*TODO*/);
            QuickSort(numbersToSort, i + 1, end /*TODO*/);
        }

        /// <summary>
        /// Rozsiruje IEnumerable
        /// Vykona akciu na kazdom elenete IEnumerable elementov typu T
        /// </summary>
        /// <typeparam name="T">Typ elementu kolekcie</typeparam>
        /// <param name="collection">Kolekcia IEnumerable</param>
        /// <param name="action">Akcia ktora sa ma vykonat pre kazdy element kolekcie</param>
        public static void ForEach</*TODO*/>( /*TODO parametre*/)
        {
            //TODO
        }

        /// <summary>
        /// Rozsiruje IEnumerable
        /// Vyfiltruje elementy kolekcie podla zadanej podmienky
        /// </summary>
        /// <typeparam name="T">Typ elementu kolekcie</typeparam>
        /// <param name="collection">Kolekcia IEnumerable</param>
        /// <param name="condition">Podmienka ktoru musia vysledne elementy splnat (Func)</param>
        /// <returns>Kolekcia prvkou ktore splnaju zadanu podmienku</returns>
        public static IEnumerable<T> Where</*TODO*/>( /*TODO parametre*/)
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
