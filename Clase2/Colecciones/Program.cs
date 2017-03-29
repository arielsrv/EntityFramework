using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            values.Add(1);
            values.Add(4);
            values.Add(9);
            values.Add(10);
            values.Add(3);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            IEnumerator<int> enumerator = values.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int current = enumerator.Current;
                Console.WriteLine(current);
            }
        }
    }


}
