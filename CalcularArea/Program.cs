using System;

namespace MyApp
{
    internal class Program
    {
        static void Nome(string mensagem)
        {
            Console.WriteLine("Olá " + mensagem + "vai ser um prazer te responder");
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
        static void Print(double message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// Calcula a area do circulo
        /// </summary>
        /// <param name="raio">valor do raio do circulo</param>
        /// <returns>retorna a area do circulo</returns>

        static double CalcularCirculo(double raio)
        {
            double valor = 0;
            valor = Math.Pow(raio, 2) * Math.PI;

            return valor;
        }

        /// <summary>
        ///  Função que calcula a area do triangulo
        /// </summary>
        /// <param name="b">comprimento da base do triangulo</param>
        /// <param name="altura">comprimento da altura do triangulo</param>
        /// <returns>retorna o valor da area do triangulo</returns>
        static double CalcularTriangulo(double b, double altura)
        {
            double valor = 0;
            valor = (b * altura) / 2;

            return valor;
        }

        /// <summary>
        /// Calcula a area do retangulo
        /// </summary>
        /// <param name="b">valor da base</param>
        /// <param name="largura">valor da largura</param>
        /// <returns>retorna a area do retangulo</returns>
        static double CalcularRetangulo(double comprimento, double largura)
        {
            double valor = 0;
            valor = comprimento * largura;

            return valor;
        }

        static void Main(string[] args)
        {
            int opcao = 0;
            string nome = "";

            Print("Qual é o seu nome?");
            nome = Console.ReadLine();
            Nome(nome);

            Console.WriteLine("O que o vc quer calcular? (obs: 1 - circulo; 2 - triangulo; 3 - retangulo)");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                double raio = 0;
                Print("Qual é o raio do circulo?");
                raio = double.Parse(Console.ReadLine());
                double resultado = CalcularCirculo(raio);
                Print(nome + ", a area do circulo é: ");
                Print(resultado);
            }
            else if (opcao == 2)
            {
                Print("Qual é a base do triangulo?");
                double b = double.Parse(Console.ReadLine());
                Print("Qual é a altura do triangulo?");
                double altura = double.Parse(Console.ReadLine());
                Print(nome + ", a area do triangulo é: ");
                Print(CalcularTriangulo(b, altura));
            }
            else if (opcao == 3)
            {
                Print("Qual é o lado do retangulo?");
                double comprimento = double.Parse(Console.ReadLine());
                Print("Qual é a largura do triangulo?");
                double largura = double.Parse(Console.ReadLine());
                Print(nome + ", a area do triangulo é: ");
                Print(CalcularRetangulo(comprimento, largura));
            }
            else
            {
                Print(nome + ", infelizmente não temos essa opção");
            }

        }
    }
}