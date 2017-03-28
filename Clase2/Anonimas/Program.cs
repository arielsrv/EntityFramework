using System;

namespace Anonimos
{
    public class Program
    {
        private delegate int MyDelegate(int a, int b);

        private delegate void Print(int value);

        private static void Main(string[] args)
        {
            MyDelegate f = delegate (int a, int b) { return a + b; };
            int result = f(2, 3);

            Print print = delegate (int value) { Console.WriteLine(value); };
            print(result);
        }               
    }
}
