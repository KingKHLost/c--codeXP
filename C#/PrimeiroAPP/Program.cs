using System;

namespace PrimeiroAPP
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Aqui é onde iremos inserir o código
            Console.WriteLine("Soma de dois números");

            int n1;
            int n2;

            Console.WriteLine("Digite o Primeiro Número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número");
            n2 = int.Parse(Console.ReadLine());

            int resp = n1+n2;
            Console.WriteLine($"O resultado é:{resp}");
            // Na parte da (resp) tem 2 metódos:Console.WriteLine(resp) e esse que está logo acima.
             

        }
    }
}
