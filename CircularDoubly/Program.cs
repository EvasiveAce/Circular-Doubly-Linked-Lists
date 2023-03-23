using System;

namespace CircularDoubly
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");
            list.Add("g");
            list.Add("h");
            list.Add("i");

            Console.WriteLine(list.Count);
            Console.WriteLine(list.itemToString("b"));
            Console.WriteLine(list.itemToString("a"));
            Console.WriteLine(list.itemToString("g"));
        }
    }
}