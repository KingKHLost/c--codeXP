using System;

namespace Calculo_do_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Só pode meia no cinema");

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if(idade<18||idade>=60){
              Console.WriteLine("Você pode pagar meia");  
            }else{
                Console.WriteLine("Paga inteira lazarento");
            }  
        }
    }
}
