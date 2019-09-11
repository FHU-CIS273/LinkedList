using System;
namespace LinkedList
{
    public interface IList
    {
        void Prepend(int item);
        void Append(int item);
        void Remove(int item);
        void InsertAfter(int existingItem, int newItem);
        bool Contains(int item);
        IList Reverse();

        int Length { get; }
        bool IsEmpty { get; }
    }
}
