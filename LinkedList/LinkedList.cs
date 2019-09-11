using System;
namespace LinkedList
{
    public class LinkedListNode
    {
        public int Data { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int data = 0, LinkedListNode next=null)
        {
            Data = data;
            Next = next;
        }
    }

    public class LinkedList: IList
    {
        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        public int Length => throw new NotImplementedException();

        public bool IsEmpty => Head==null;

        public void Append(int item)
        {
            // create new node
            LinkedListNode newNode = new LinkedListNode(item);

            // make tail's next point to the new node
            Tail.Next = newNode;
            Tail = newNode;

        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void InsertAfter(int existingItem, int newItem)
        {
            throw new NotImplementedException();
        }

        public void Prepend(int item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int item)
        {
            throw new NotImplementedException();
        }

        public IList Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
