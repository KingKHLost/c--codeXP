using System;

namespace Arrys_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo Efetuar cadastro de usuario com os seguintes dados.
            //Nome,Telefone e Emaiil.
            Console.WriteLine("Exercicio de Arrys 2");

            string[] nomes = new string[5];
            string[] telefones = new string[5];
            string[] emails = new string[5];

            int contador = 0;
            while(contador < 3){
                Console.WriteLine("Digite o seu nome");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone");
                telefones[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu Email");
                emails[contador] = Console.ReadLine();

                contador++;
            }//fim do While

            int contadorB = 0;
            while(contadorB <= 3){
                Console.WriteLine($"O cliente número {contadorB+1} - Nome: {nomes[contadorB]}, Tel: {telefones[contadorB]} - Email: {emails[contadorB]}");
                contadorB++;
            }
            //fim do WhileB
        }
    }
}
