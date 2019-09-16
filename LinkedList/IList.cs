using System;
namespace LinkedList
{
    public interface IList<T>
    {
        void Prepend(T item);
        void Append(T item);
        void Remove(T item);
        bool InsertAfter(T existingItem, T newItem);
        bool Contains(T item);
        IList<T> Reverse();

        T this[int index] { get; }

        int Length { get; }
        bool IsEmpty { get; }
    }
}
