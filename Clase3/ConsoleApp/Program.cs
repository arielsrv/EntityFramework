using Collections;
using System;
using static System.Console;
using System.Linq;

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

            WriteLine("\nEjercicios:\n");

            int first = collection.First();
            WriteLine($"\tPrimer elemento: {first}");

            int last = collection.Last();
            WriteLine($"\tUltimo elemento: {last}");

            int n = 3;
            var result1 = collection.From(n);
            WriteLine($"\tA partir de: {n}");
            foreach (var item in result1)
            {
                WriteLine(item);
            }

            Func<int, int> f1 = x => x * 2;
            WriteLine($"\tColección modificada:");
            var result2 = collection.Map(f1);
            foreach (var item in result2)
            {
                WriteLine(item);
            }

            Func<int, int, int> f2 = (total, item) => total = total + item; 
            var result3 = collection.Reduce(f2);
            WriteLine($"\tReducción de la colección: {result3}");

            Func<int, bool> f3 = x => x > 3;
            WriteLine($"\tColección filtrada:");
            var result4 = collection.Find(f3);
            foreach (var item in result4)
            {
                WriteLine(item);
            }

            var result5 = collection
                .From(1)
                .Find(x => x > 2)
                .Map(x => x * 2)
                .Reduce((total, item) => total = total + item);
            WriteLine($"\tBienvenidos al mundo de LinQ: {result5}");           
        }
    }
}
