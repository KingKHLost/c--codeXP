using System;

namespace App_de_Calculo_de_média
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App de calculo de média");
            Console.WriteLine("Bem vindo a Escola SENAI de Informática");
            //Entrada de dados.
            Console.WriteLine("Digite a Primeira Nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Segunda Nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            //Processamento
            double media = (nota1+nota2)/2;

            if(media>=50 && faltas<=30){
                //Resultado verdadeiro.
                Console.WriteLine("Parabéns você foi Aprovado!");
            }else{
                //Resultado Falso.
                Console.WriteLine("Parabéns você foi Reprovado");
            }
        }
    }
}
