using System;
using System.Collections.Generic;

namespace Events
{
    /// <summary>
    /// TODO:
    /// Zacit implementaci udalosti ItemsModified,
    /// dal implementovat OnCollectionModified, ...
    /// </summary>
    public class SimpleObservableCollection<T>
    {
        private readonly IList<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);

            // TODO - zde vyvolat udalost ItemsModified
            // ...

        }

        public void Remove(T item)
        {
            if (items.Contains(item))
            {
                items.Add(item);

                // TODO - zde vyvolat udalost ItemsModified
                // ...

            }
        }

        // TODO - pridani udalosti ItemsModified
        // ...

        // TODO - pridani metody OnCollectionModified (vyvolani udalosti)
        // vyuzit CollectionModifiedEventArgs
        // ...
    }
}
