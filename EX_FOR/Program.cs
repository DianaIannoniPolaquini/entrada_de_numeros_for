using System;

namespace EX_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            Console.WriteLine("Quantos números vc deseja que o prog leia? ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int n);

            int soma = 0;
            int n1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite o {i}º número: ");
                n1 = int.Parse(Console.ReadLine());
                soma += n1;
            }
            Console.WriteLine($"A soma dos números inseridos é {soma}");
        }
    }
}
