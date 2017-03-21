using System;
using System.Collections.Generic;

class Clase1
{
    static void Main(string[] args)
    {
        List<int> values = new List<int>();
        values.Add(1);
        values.Add(2);
        values.Add(3);
        values.Add(4);
        values.Add(5);

        foreach (int item in values) 
        {
            Console.WriteLine(item);
        }

        MyCollection<int> numbers = new MyCollection<int>();
        numbers.Add(1);
        //numbers.Add("Hello world!"); // Esta línea no compila porque fue declarada cómo Int.32.

        string x = "cadena 1";
        string y = "cadena 2";

        // Método genérico (no necesariamente implica una clase genérica)
        Swap<string>(x, y);
    }

    static void Swap<T>(T x, T y) 
    {
        
    }

    class MyCollection<T>
    {
        public void Add(T value)
        {
            //TBD
        }
    }
}
