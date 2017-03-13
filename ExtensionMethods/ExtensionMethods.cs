using System.Collections.Generic;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        //Vyberte si 3 funkcie a implementujte (kto stihne aj vsetky)

        /// <summary>
        /// vrati prvni 4 znaky daneho retezce (pokud ma delku > 4)
        /// </summary>
        /// <param name="word">retezec v ramci ktereho vrati prvni 4 znaky</param>
        /// <returns></returns>
        public static string GetFirstFourChars(/* TODO - add parameters */)
        {
            // TODO
            // ...
        }

        /// <summary>
        /// Funkcia rozsiruje kolekciu stringov
        /// </summary>
        /// <typeparam name="T">Typ prvku kolekcie.</typeparam>
        /// <param name="strings">IEnumerable stringov ktore chceme spojit don vysledneho retazca.</param>
        /// <param name="separator">Oddelovac (string) ktorim budu jednotlive polozky kolekcie oddelene</param>
        /// <returns>Vysledny retazec ktori vznikol spojenim retazcov v kolekcii</returns>
        public static string StringJoin</*TODO*/>(/* TODO - add parameters */)
        {
            string.Join()
            //TODO
            //...
        }


        /// <summary>
        /// Pocita slova v ramci daneho radku (retezce)
        /// </summary>
        /// <param name="line">retezec v ramci ktereho se pocita vyskyt slov</param>
        /// <returns></returns>
        public static int CountWordsWithinLine(/* TODO - add parameters */)
        {
            line
            // TODO
            // ...
        }


        /// <summary>
        /// pocita vyskyt daneho prvku v kolekci
        /// </summary>
        /// <typeparam name="T">typ prvku v kolekci</typeparam>
        /// <param name="collection">kolekce ve ktere prvek hledame</param>
        /// <param name="itemToMatch">prvek, jehoz vyskyt hledame</param>
        /// <returns>vrati pocet vyskytu daneho prvku v kolekci</returns>
        public static int CountOccurancesOfElement<T>(/* TODO - add parameters */)
        {
            
            // TODO
            // ...
        }
    }
}
