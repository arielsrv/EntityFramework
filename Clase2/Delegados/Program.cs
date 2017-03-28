
using System;

namespace Delegados
{
    class Program
    {
        delegate int MyDelegate (int a, int b);
        delegate void Print(int value);

        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            MyDelegate f = Sum;

            int result = f(2, 3);

            Print print = Console.WriteLine;

            print(result);
        }
        
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subs(int a, int b)
        {
            return a - b;
        }
    }
}
