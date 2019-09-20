using System;

namespace Calculo_por_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nascimento");
            int nascimento = int.Parse(Console.ReadLine());
            
            int anoatual = DateTime.Now.Year;
            
            int idade = anoatual-nascimento;

            int semanas = idade * 52; 
        
            Console.WriteLine($"A idade é {idade} e as semana são: {semanas} ");
        }
    }
}
