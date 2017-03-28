using System;

namespace DelegadosGenericos
{
    public class Program
    {        
        private static void Main(string[] args)
        {
            Func<int, int, int> f = (a, b) => a + b;
            int result = f(2, 3);

            Action<int> print = (value) => Console.WriteLine(value);
            print(result);            
        }        
    }
}
