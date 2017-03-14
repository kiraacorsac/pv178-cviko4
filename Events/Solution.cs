﻿using System;
using System.Collections.Generic;

namespace cv04
{
    /// <summary>
    /// inspired by ObservableCollection
    /// https://msdn.microsoft.com/en-us/library/ms668604(v=vs.110).aspx
    /// </summary>
    public static class Solution
    {
        public static void TestSolution()
        {
            var observableCollection = new SimpleObservableCollection<int>();

            observableCollection.ItemsModified += PrintModifications;

            observableCollection.Add(1);
            observableCollection.Add(2);
            observableCollection.Remove(2);

            observableCollection.ItemsModified -= PrintModifications;

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

    public class SimpleObservableCollection<T>
    {
        private readonly IList<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
            OnCollectionModified(new CollectionModifiedEventArgs<T>(item, OperationType.Add));
        }

        public void Remove(T item)
        {
            if (items.Contains(item))
            {
                items.Add(item);
                OnCollectionModified(e: new CollectionModifiedEventArgs<T>(item, OperationType.Remove));
            }
        }

        public event EventHandler ItemsModified;

        protected void OnCollectionModified(CollectionModifiedEventArgs<T> e) => ItemsModified?.Invoke(this, e);
    }


    public class CollectionModifiedEventArgs<T> : EventArgs
    {
        public OperationType Type { get; }

        public string ModifiedValue { get; }

        public CollectionModifiedEventArgs(T item, OperationType type)
        {
            Type = type;
            ModifiedValue = item.ToString();
        }
    }


    public enum OperationType
    {
        Add,
        Remove
    }
}
