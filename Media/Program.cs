// Projeto de Avaliação (Revisado) - Variante 3: Cálculo de média de três notas
// Este programa deve solicitar o nome do estudante e três notas, calcular e exibir a média.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do estudante:");

        string nome = Console.ReadLine();
        double soma = 0;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Digite a nota " + i + ":");
            double nota = double.Parse(Console.ReadLine());

            soma = soma + nota;
        }

        double media = soma / 3;
        Console.WriteLine("A média do estudante " + nome + " é " + media);
    }
}