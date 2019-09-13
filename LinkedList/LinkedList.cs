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

        // TODO
        public int Length => throw new NotImplementedException();

        public bool IsEmpty => Head==null;

        // TODO
        /***
         * return the item at the given index in the list.
         */
        public int this[int index]
        {
            get
            {
                return 0;
            }
        }

        /***
         * Add item to the back of the list.
         */
        public void Append(int item)
        {
            // create new node
            LinkedListNode newNode = new LinkedListNode(item);

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
        /***
        * Insert newItem after first matching existingItem in list if exsitingItem is present.
        * return true if existingItem is present; otherwise, return false.j
        */
        public bool InsertAfter(int existingItem, int newItem)
        {
            throw new NotImplementedException();
        }

        // TODO
        /***
         * Add item to the front of the list.
         */
        public void Prepend(int item)
        {
            throw new NotImplementedException();
        }

        // TODO
        /***
         * Remove first matching item from list (if it exists).
         */
        public void Remove(int item)
        {
            throw new NotImplementedException();
        }

        // TODO
        /***
         * Return a new list with this list's elements in reversed order.
         */
        public IList Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
