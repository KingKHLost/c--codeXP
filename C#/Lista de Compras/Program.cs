using System;

namespace Lista_de_Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de compras do Tsukamoto");

            string[] listas = new string[6];
            
            int contador = 0;
            while(contador <6){
                Console.WriteLine($"Digite os produtos{contador+1}º");
                listas[contador] = Console.ReadLine();
                
                contador++;   
            }
            int contadorB = 0;
            while(contadorB <=5){
            Console.WriteLine($"A lista final é essa: {contadorB+1}º - {listas[contadorB]}");
            contadorB++;
            }
           
        }
    }
}
