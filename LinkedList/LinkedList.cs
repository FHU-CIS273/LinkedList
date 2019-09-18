using System;

namespace LinkedList
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data = default(T), LinkedListNode<T> next=null)
        {
            Data = data;
            Next = next;
        }
    }

    public class LinkedList<T>: IList<T>
    {
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }

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
        public T this[int index]
        {
            get
            {
                return default(T);
            }
        }

        /***
         * Add item to the back of the list.
         */
        public void Append(T item)
        {
            // create new node
            LinkedListNode<T> newNode = new LinkedListNode<T>(item);

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

        public bool Contains(T item)
        {
            LinkedListNode<T> currentNode = Head;
            while( currentNode != null )
            {
                if (currentNode.Data.Equals(item))
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
        public bool InsertAfter(T existingItem, T newItem)
        {
            throw new NotImplementedException();
        }

        // TODO
        /***
         * Add item to the front of the list.
         */
        public void Prepend(T item)
        {
            throw new NotImplementedException();
        }

        // TODO
        /***
         * Remove first matching item from list (if it exists).
         */
        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        // TODO
        /***
         * Return a new list with this list's elements in reversed order.
         */
        public IList<T> Reverse()
        {
            IList<T> reversedList = new LinkedList<T>();

            LinkedListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                reversedList.Prepend(currentNode.Data);
                currentNode = currentNode.Next;
            }

            return reversedList;
        }

    }
}
