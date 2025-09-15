using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array de números
            int[] listaNumeros = { 5, 6, 4, 13 };

            Console.WriteLine("Digite 4 números separados por espaço:");
            string[] entrada = Console.ReadLine().Split(' ');
            int[] numeros = Array.ConvertAll(entrada, int.Parse);

            // Verifica se o usuário digitou 4 números
            if (entrada.Length != listaNumeros.Length)
            {
                Console.WriteLine("Você deve digitar exatamente 4 números.");
                return;
            }

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (numeros[i] == listaNumeros[i])
                {
                    Console.WriteLine($"Dígito {i + 1} correto");
                    // listaNumeros.Length - 1 é o último índice do array (e tambem para saber se é o último dígito) 
                    if (i == listaNumeros.Length - 1)
                    {
                        Console.WriteLine("Senha correta");
                    }
                }
                else
                {
                    Console.WriteLine($"Dígito {i + 1} incorreto");
                }
            }

        }
    }
}