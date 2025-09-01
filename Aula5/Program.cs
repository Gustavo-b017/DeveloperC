using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    internal class Program
    {
        static void ForPositivo(double i)
        {
            // inicia uma variavel, e atribui o valor 0 a ela
            // depois coloca uma condicao e depois incrementa 1 para ir para a proxima
            // i e index

            /// <summary>
            /// Função que recebe um numero total, e ira imprimir todos os numeros de 0 até o numero total usando o for
            /// </summary>
            /// <param name="i">valor limite que a iteração ira mostrar </param>
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"For numero: {j}");
            }
        }

        /// <summary>
        /// Função que recebe um numero total, e ira imprimir todos os numeros de 0 até o numero total usando o while
        /// </summary>
        /// <param name="i">valor limite que a iteração ira mostrar </param>
        static void WhilePositivo(double i)
        {
            int j = 0;
            while (j < i)
            {
                Console.WriteLine($"While numero: {j}");
                j++;
            }
        }

        /// <summary>
        /// Função que recebe um numero total, e ira somar todos os numeros de 0 até o numero total
        /// </summary>
        /// <param name="i">qtd total de numeros que ira somar</param>
        static void SomarNumeros(double i)
        {
            double soma = 0;
            int j = 0;

            while (j <= i)
            {
                soma += j;
                j++;
            }

            Console.WriteLine($"Soma dos numeros: {soma}");
        }

        /// <summary>
        /// Função que recebe um array de strings e imprime cada nome na tela
        /// </summary>
        /// <param name="nomes">Lista de nomes que ira mostrar</param>
        static void ForEachNomes(string[] nomes)
        {
            foreach (string nome in nomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }
        }

        /// <summary>
        /// Criar um triangulo usando o for e *
        /// </summary>
        static void TringuloFor()
        {
            for (int j = 0; j <= 9; j++)
            {
                for (int k = 0; k <= j; k++)
                {
                    //Console.WriteLine($"For Duplo: {j} - {k}");
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Função que recebe um numero total e um valor, e verifica se o valor existe no loop for de 0 até o numero total
        /// </summary>
        /// <param name="lista">numero de elementos total na lista</param>
        /// <param name="valor">valor que quer encontrar na lista</param>
        static void EncontrarValor(double lista, double valor)
        {
            for (int i = 0; i < lista; i++)
            {
                if (i == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado no loop for!");
                    break; // Encerra o loop quando o valor é encontrado
                }
            }
        }

        /// <summary>
        /// Imprime todos os numeros impares de 0 até 100, pulando os pares
        /// </summary>
        static void PassarPares()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Pula para a próxima iteração se o número for par
                }

                Console.WriteLine($"Numero impar: {i}");
            }
        }

        static void Main(string[] args)
        {
            
            ForPositivo(10);

            WhilePositivo(10);

            SomarNumeros(100);

            String[] nomes = { "João", "Maria", "José", "Ana", "jao", "gabriel" };

            ForEachNomes(nomes);

            TringuloFor();

            EncontrarValor(100, 45);

            PassarPares();
        }
    }
}