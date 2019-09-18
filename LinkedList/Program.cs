using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Append(2);
            linkedList.Append(4);
            linkedList.Append(6);
            linkedList.Append(8);
            linkedList.Append(10);
            linkedList.Append(12);

            Console.WriteLine(linkedList.Contains(3));

            LinkedList<string> linkedListString = new LinkedList<string>();

            linkedListString.Append("Maggie");
            linkedListString.Append("Alexis");
            linkedListString.Append("Michael");

            // get
            var value = linkedList[2];
             
            Console.WriteLine( linkedListString[2] );

            Console.WriteLine(linkedListString);
        }
    }
}
