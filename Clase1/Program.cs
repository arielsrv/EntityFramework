using System;
using System.Collections.Generic;

public static class DoubleExtensions
{        
    public static double Sin(this double value)
    {
        return Math.Sin(value);
    }
}

public static class StringExtension
{   
    public static string Reverse(this string value) 
    {
        return value;
    }
}

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

        double result = 123;
        Console.WriteLine(result.Sin());

        //string reverse = "hello".Reverse();
        //string reverse = StringExtension.Reverse("hello");

        int i  = 123;

        var a = 123;
        
        var cadena = default(string);
        cadena = string.Empty;

        // cadena = 123; "NO COMPILA"

        List<List<int>> myList1 = new List<List<int>>();
        var myList2 = new List<List<int>>();

        dynamic value = "Hello world";
        value.RompeTodo();

        value = 123;


        Customer customer1 = new Customer();
        customer1.Id = 123;
        customer1.Name = "Jorge Sanchez";

        var customer2 = new Customer()
        {
            Id = 123,
            Name = "Jorge Sanchez"            
        };
        //Customer customer = new Customer(123, "Jorge Sanchez");
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
