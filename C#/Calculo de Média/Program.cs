using System;

namespace Calculo_de_Média
{
    class Program
    {
        static void Main(string[] args)
        {
            // Início.
            Console.WriteLine("A soma de três números");

            int n1;
            int n2;
            int n3;

            Console.WriteLine("Digite o Primeiro Número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro Número");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro Número");
            n3 = int.Parse(Console.ReadLine());

            float soma = (n1+n2+n3);
            float resp = soma/3;
            // float resp = (resp)(n1+n2+n3)/3;Esse também é um modo de fazer essa conta.   
            Console.WriteLine($"O resultado é:{resp}");
            // Quando for resposta de algarismo tem que colocar o (Float) para conseguir pegar se for numero quebrado.
            // Não pode declarar variavel com letra maiuscula e caracter especial.
            // $:interpolação é para puxar uma variavel dentro de um string que é {}.
            // Seguir sempre o fluxograma.
            // É bom fazer uma quebra e colocar 2 variaveis.Primeiro pegar a soma e depois pegar outros(%,/).
            // Fim.

        }
    }
}
