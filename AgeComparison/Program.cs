using System;

namespace MyApp
{
    internal class Program
    {
        static double raio = 0;

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
        static void Print(double message)
        {
            Console.WriteLine(message);
        }

        static double CalcularCirculo(double valor)
        {
            double raio = 0;
            raio = Math.Pow(valor, 2) * Math.PI;

            return raio;
        }

        static void Main(string[] args)
        {
            Print("Qual é o raio do circulo?");

            raio = double.Parse(Console.ReadLine()); // le o valor do raio escrita no terminal e coloca em uma variavel do tipo double

            double resultado = CalcularCirculo(raio); // o resultado é do tipo double
            Print("area do circulo é: " + resultado); // porcausa da concatenação o resultado é convertido para string
            Print(resultado); // por causa da sobrecarga o resultado é impresso como double
        }
    }
}