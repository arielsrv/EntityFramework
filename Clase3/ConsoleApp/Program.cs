using Collections;
using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> collection = new MyCollection<int> { 2, 5, 1, 19, 10, 3 };

            foreach (var item in collection)
            {
                WriteLine(item);
            }

            int first = collection.First();
            WriteLine($"Primer elemento: {first}");
        }
    }
}
