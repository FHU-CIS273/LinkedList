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

        // TODO
        public int this[int index]
        {
            get
            {
                return 0;
            }
        }

        public void Append(int item)
        {
            // create new node
            LinkedListNode newNode = new LinkedListNode(item);

            // empty list
            if(IsEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                // make tail's next point to the new node
                Tail.Next = newNode;
                Tail = newNode;
            }

        }

        public bool Contains(int item)
        {
            LinkedListNode currentNode = Head;
            while( currentNode != null )
            {
                if( currentNode.Data == item)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }

            // OR

            /*for(LinkedListNode currentNode = Head;
                currentNode != null;
                currentNode = currentNode.Next)
            {
                if (currentNode.Data == item)
                {
                    return true;
                }
            }*/

            return false;
        }

        // TODO
        public bool InsertAfter(int existingItem, int newItem)
        {
            throw new NotImplementedException();
        }

        // TODO
        public void Prepend(int item)
        {
            throw new NotImplementedException();
        }

        // TODO
        public void Remove(int item)
        {
            throw new NotImplementedException();
        }

        // TODO
        public IList Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
