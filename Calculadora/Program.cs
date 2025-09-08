// Projeto de Avaliação (Revisado) - Variante 4: Mini Calculadora com menu
// O código abaixo deve exibir um menu de operações e executar a escolhida, repetindo até que o usuário deseje sair.

using System;

class Program
{
    static void Main()
    {
        bool encerrar = false;

        while (!encerrar)
        {
            Console.WriteLine("1 Somar");
            Console.WriteLine("2 Subtrair");
            Console.WriteLine("3 Multiplicar");
            Console.WriteLine("4 Dividir");
            Console.WriteLine("0 Sair");
            Console.WriteLine(" ");
            Console.Write("Escolha: ");

            int opcao = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine(" ");
            
            if (opcao == 0)
            {
                encerrar = true;
                Console.WriteLine("Até a próxima!");
                break;
            }

            Console.WriteLine("Digite o primeiro número: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite o segundo número: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"O resultado da soma de {x} e {y} é: {x + y}");
                    Console.WriteLine(" ");
                    break;

                case 2:
                    Console.WriteLine($"O resultado da subtração de {x} e {y} é: {x - y}");
                    Console.WriteLine(" ");
                    break;

                case 3:
                    Console.WriteLine($"O resultado da multiplicação de {x} e {y} é: {x * y}");
                    Console.WriteLine(" ");
                    break;

                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("Divisão por zero não existe");
                        Console.WriteLine(" "); 
                        break;
                    }
                    Console.WriteLine($"O resultado da divisão de {x} e {y} é: {x / y}");
                    Console.WriteLine(" ");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

    }
}
