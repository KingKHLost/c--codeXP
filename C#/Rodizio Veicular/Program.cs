using System;

namespace Rodizio_Veicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio do inferno");
            
            Console.WriteLine("Coloque o número da sua placa");
            // int placa = int.Parse(Console.ReadLine());
            string placa = Console.ReadLine();

            int caracteres = placa.Length;
            // abc1234
            int final = int.Parse(placa.Substring(caracteres - 1));

            Console.WriteLine($"A posição 0 é:{final}");
            if(final==0 || final==1 ){
                Console.WriteLine("Seu rodizio é Segunda-Feira");
            }else if(final==2 || final==3 ){
                Console.WriteLine("Seu rodizio é Terça-Feira");
            }else if(final==4 || final==5 ){
                Console.WriteLine("Seu rodizio é Quarta-Feira");
            }else if(final==6 || final==7 ){
                Console.WriteLine("Seu rodizio é Quinta-Feira");
            }else if(final==8 || final==9 ){
                Console.WriteLine("Seu rodizio é Sexta-Feira");
            }else{
                Console.WriteLine("Insira apenas um digito");
            }
        }
    }
}
