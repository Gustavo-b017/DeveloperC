using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace MyApp
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int altura = 20; // Altura da pirâmide
            int linha = 1; // Linha atual da pirâmide
            while (linha <= altura)
            {
                for (int i = 0; i < (altura - linha); i++)
                {
                    Console.Write(" "); // Imprime espaços em branco
                }

                for (int i = 0; i < (2 * linha - 1); i++)
                {
                    Console.Write("/|"); // Imprime asteriscos
                }

                Console.WriteLine(); // Pula para a próxima linha
                linha++; // Incrementa a linha atual
            }
        }
    }
}