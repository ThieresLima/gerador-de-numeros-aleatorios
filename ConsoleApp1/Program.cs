using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números Aleatórios!");
            Console.WriteLine();

            Random Aleatorio = new Random();
            Console.Write("Inicial: ");
            int inicial = int.Parse(Console.ReadLine());
            Console.Write("Final: ");
            int final = int.Parse(Console.ReadLine());
            Console.Write("Limite de numeros: ");
            int limite = int.Parse(Console.ReadLine());

            string resultado = "";

            for (int i = 1; i <= limite; i++ )
            {
                resultado = resultado + " " + Aleatorio.Next(inicial, final);
            }

            Console.WriteLine("Números sorteados: " + resultado);
        }
    }
}
