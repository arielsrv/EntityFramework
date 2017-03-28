using System;

namespace Funciones
{
    public class Program
    {
        private delegate int MyDelegate(int a, int b);

        private delegate void Print(int value);

        private static void Main(string[] args)
        {
            MyDelegate f = (a, b) => a + b;
            int result = f(2, 3);

            Print print = (value) => Console.WriteLine(value);
            print(result);
        }
    }
}
