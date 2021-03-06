﻿using System;

namespace Delegados
{
    public class Program
    {
        private delegate int MyDelegate(int a, int b);

        private delegate void Print(int value);

        private static void Main(string[] args)
        {
            MyDelegate f = Sum;
            int result = f(2, 3);

            Print print = Console.WriteLine;
            print(result);
        }

        private static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}