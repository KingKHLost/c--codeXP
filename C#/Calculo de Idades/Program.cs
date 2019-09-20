using System;

namespace Calculo_de_Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("A idade é");
            idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias =  idade * 365;
            int horas = dias * 24;
            int minutos = horas * 60;
// isso da parte da int são as variaveis que são constante.

            Console.WriteLine($"Idade em meses é: {meses}, Idade em dias é: {dias}, Idade em horas é: {horas}, Idade em minutos é: {minutos}");

        }
    }
}
