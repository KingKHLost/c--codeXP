using System;

namespace Agencia_de_turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agência de Turismo");
            //Entrada de Dados.
            string[] nome = new string[3];
            string[] origem = new string[3];
            string[] destino = new string[3];
            DateTime[] data = new DateTime[3];//Armazenar data.
            
            int opcao = 0;int contador = 0;
            
            do
            {
                Console.WriteLine("Selecione uma opção.");
                Console.WriteLine("1- Cadastrar Passagem");
                Console.WriteLine("2-Listar Passagem");
                Console.WriteLine("0-Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                    Console.WriteLine("Vamos Cadastrar Agora");
                    string resposta;
                    do{
                        if(contador <2){

                            Console.WriteLine("Digite o nome do passageiro");
                            nome[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a Origem");
                            origem[contador] = Console.ReadLine();

                            Console.WriteLine("Digite o Destino");
                            destino[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a data do seu Vôô");
                            data[contador] = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Você deseja cadastrar mais um? S/N");
                            resposta = Console.ReadLine();
                            contador++;
                        
                        }
                        else{
                            Console.WriteLine("Numéro de passagens Excedidas");
                        break;
                        }

                    } while(resposta == "S");

                    break;
                    case 2:
                    Console.WriteLine("Listando as Passagens");
                        int contadorB = 0;
                        while(contador <2);
                        {
                            Console.WriteLine($"Passageiro{nome[contadorB]},Origem:{origem[contadorB]},Destino:{destino[contadorB]},Data:{data[contadorB]}");
                            contadorB++;
                        }

                    break;
                    case 0:
                    break;
                    default:
                    Console.WriteLine("Opção Inválida");
                    break;
                }//Fim do Switch
            } while (opcao !=0);

            Console.WriteLine("Obrigado por usar nosso sistema");
        }
    }
}
