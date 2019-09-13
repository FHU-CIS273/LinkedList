using System;
namespace LinkedList
{
    public interface IList
    {
        void Prepend(int item);
        void Append(int item);
        void Remove(int item);
        bool InsertAfter(int existingItem, int newItem);
        bool Contains(int item);
        IList Reverse();

        int this[int index] { get; }

        int Length { get; }
        bool IsEmpty { get; }
    }
}
