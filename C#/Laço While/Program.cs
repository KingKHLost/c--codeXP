using System;

namespace Laço_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While com Array");

            string[] nomes = new string [3];
            nomes[0] = "Carlos";
            nomes[1] = "Carol";
            nomes[2] = "André";

            Console.WriteLine($"O nome na posição 2 é {nomes[2]}");

        }
    }
}
