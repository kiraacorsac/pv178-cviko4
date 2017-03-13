using System;

namespace Events
{
    /// <summary>
    /// Ukol: ObservableCollection
    /// 
    /// I. Dokonceni implementace SimpleObservableCollection
    /// 
    /// II. Doplneni nize uvedene metody Main (viz TODO)
    /// 
    /// III. Po spusteni programu by melo dojit k vypsani
    ///      zpravy pri vyvolani udalosti
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var observableCollection = new SimpleObservableCollection<int>();

            // TODO: prihlasit se k odberu udalosti ItemsModified
            // metoda na vypis je jiz implementovana
            // ... 

            observableCollection.Add(1);
            observableCollection.Add(2);
            observableCollection.Remove(2);

            // TODO: odhlasit se z odberu udalosti ItemsModified
            // ... 

            Console.ReadKey();
        }

        private static void PrintModifications(object sender, EventArgs e)
        {
            var args = e as CollectionModifiedEventArgs<int>;
            if (args == null)
            {
                return;
            }

            switch (args.Type)
            {
                case OperationType.Add:
                    Console.WriteLine($"Added element {args.ModifiedValue} to collection.");
                    break;
                case OperationType.Remove:
                    Console.WriteLine($"Removed element {args.ModifiedValue} from collection.");
                    break;
            }
        }
    }
}
