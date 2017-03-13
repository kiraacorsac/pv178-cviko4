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
            TestPrintRepeatedly();

            TestCheckPalindrome();

            TestPrintGreaterThan();
        }


        private static void TestPrintRepeatedly()
        {
            /* 
            Zde vytvorte generickeho delegata (Action<...>)
            do ktereho vlozite lambda vyraz, ktery:
            
            - opakovane vypisuje dany retezec do konzole

            - bude mit parametr typu string: retezec, ktery 
              se bude opakovane tisknout na vystup
            
            -  bude mit parametr typu int: udava, kolikrat se
               ma dany retezec vytisknout

            na zaver odkomentujte nize uvedene volani...
            */
            // TODO ...

            //Utils.PrintRepeatedly(printRepeatedlyAction);
        }

        private static void TestCheckPalindrome()
        {
            /* 
            Zde vytvorte generickeho delegata (Func<...>)
            do ktereho vlozite lambda vyraz, ktery:

            - kontroluje vyskyt palindromu v danem retezci
            
            - bude mit parametr typu string: retezec, v ramci
              ktereho se bude kontrolovat vyskyt palindromu
            
            -  navratovy typ (bool) udava, zda retezec obsahuje
               palindrom

            na zaver odkomentujte nize uvedene volani...
            */
            // TODO ...

            //Utils.CheckPalindromes(isPalindrome);
        }

        private static void TestPrintGreaterThan()
        {
            /* 
            Zde vytvorte generickeho delegata (Func<...>)
            do ktereho vlozite lambda vyraz, ktery:

            - vybira hodnoty vetsi nez zadane mez z dane kolekce
            
            - bude mit parametr typu IEnumerable<int>: kolekce,
              v ramci ktere se budou filtrovat hodnoty

             - bude mit parametr typu int: spodni mez (z kolekce
               se budou vybirat hodnoty vetsi nez tato spodni mez)
            
            -  navratovy typ (IEnumerable<int>) cisla vetsi nez
               spodni mez

            na zaver odkomentujte nize uvedene volani...
            */
            // TODO ...

            //Utils.PrintGreaterThanLimit(getGreaterThan);
        }
    }
}