using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Append(2);
            linkedList.Append(4);
            linkedList.Append(6);
            linkedList.Append(8);
            linkedList.Append(10);
            linkedList.Append(12);

            Console.WriteLine(linkedList.Contains(3));
        }
    }
}
