using System;
namespace LinkedList
{

    public class DoublyLinkedListNode<T>
    {
        public T Data { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }

        public DoublyLinkedListNode(T data = default(T), DoublyLinkedListNode<T> prev = null, DoublyLinkedListNode<T> next = null)
        {
            Data = data;
            Prev = prev;
            Next = next;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
    public class DoublyLinkedList<T>: IList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public int Length
        {
            get
            {
                int count = 0;
                DoublyLinkedListNode<T> currentNode = Head;
                while(currentNode!=null)
                {
                    count++;
                    currentNode = currentNode.Next;
                }

                return count;
            }
        }

        public bool IsEmpty => Head == null;

        public T First => Head == null ? default(T) : Head.Data;
        public T Last => Tail == null ? default(T) : Tail.Data;

        /***
         * return the item at the given index in the list.
         */
        public T this[int index]
        {
            get
            {
                int count = 0;
                DoublyLinkedListNode<T> currentNode = Head;
                while (currentNode != null)
                {
                    if(count == index)
                    {
                        return currentNode.Data;
                    }
                    count++;
                    currentNode = currentNode.Next;
                }

                return default(T);

            }
        }

        /***
         * Add item to the back of the list.
         */
        public void Append(T item)
        {
            // create new node
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(item);

            if (IsEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                // make tail's next point to the new node
                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
        }

        public T KthToLast(int k)
        {
            return default(T);
        }

        public bool Contains(T item)
        {
            DoublyLinkedListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                if (item.Equals(currentNode.Data))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }
            return false;
        }

        // TODO
        /***
        * Insert newItem after first matching existingItem in list if exsitingItem is present.
        * Return true if existingItem is present; otherwise, return false.j
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
         * Remove FIRST matching item from list (if it exists).
         * Return whether or not the element was found.
         */
        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        // TODO
        /***
         * Remove LAST matching item from list (if it exists).
         * Return whether or not the element was found.
         */
        public void RemoveLast(T item)
        {
            throw new NotImplementedException();
        }



        public IList<T> Reverse()
        {
            IList<T> reversedList = new DoublyLinkedList<T>();

            DoublyLinkedListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                reversedList.Prepend(currentNode.Data);
                currentNode = currentNode.Next;
            }

            return reversedList;
        }

        public override string ToString()
        {
            string str = "[";

            var currentNode = Head;
            while (currentNode != null)
            {
                str += currentNode;

                if (currentNode != Tail)
                {
                    str += ", ";
                }

                currentNode = currentNode.Next;
            }

            str += "]";

            return str;
        }
    }
}
