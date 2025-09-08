// Projeto de Avaliação (Revisado) - Variante 1: Cálculo de Fatorial
// O código abaixo contém diversos erros de sintaxe e lógica para serem corrigidos.
// Objetivo: solicitar um número inteiro ao usuário e calcular o seu fatorial.


using System;

class Program
{
    static int Fatorial(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("O fatorial de 0 é 1");
        }

        int total = 1;

        for (int i = 1; i <= n; i++)
        {
            total = total * i;
        }
        return total;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");

        int num = int.Parse(Console.ReadLine());
        int result = Fatorial(num);
        Console.WriteLine($"O fatorial de {num} é: {result}");
    }


}