using System;

namespace Events
{
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
}
