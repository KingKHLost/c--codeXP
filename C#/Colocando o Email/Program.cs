using System;

namespace Colocando_o_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque o @ no email");
            string email;
            do{
                Console.WriteLine("Digite seu E-Mail");
                email = Console.ReadLine();
            }while(!email.Contains("@") || !email.Contains("."));

            string senha;
            do
            {
                Console.WriteLine("Digite sua Senha");
                senha = Console.ReadLine();
            }while(senha.Length <=6);

                        
        }
    }
}
