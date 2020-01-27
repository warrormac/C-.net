using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(4);
            lista.Add(6);
            lista.Add(10);

            int p = 0;

            Console.WriteLine();
            foreach (int k in lista)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
                p++;
            }

            Console.WriteLine();
            p = 0;
            lista.Remove(4);
            foreach (int k in lista)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
                p++;
            }

            Console.WriteLine();
            lista.Sort();
            Console.WriteLine("Sorted List:");
            p = 0;
            foreach (int k in lista)
            {
                Console.Write("At Position {0}: ", p);
                Console.WriteLine(k);
            }

        }
    }
}
