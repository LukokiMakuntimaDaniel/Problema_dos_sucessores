using System;
using System.Collections.Generic;

namespace Problema_dos_sucessores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                numeros.Add(n);
                n = int.Parse(Console.ReadLine());
            }

            foreach(var v in numeros)
            {
                Console.WriteLine(v+1);
            }
        }
    }
}
