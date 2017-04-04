using Collections;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<int> collection = new MyCollection<int> { 2, 5, 1, 19, 10, 3 };

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
