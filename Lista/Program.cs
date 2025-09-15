using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array de int
            int[] listaNumeros = { 5, 6, 4, 13 };

            int[] numeros = { 0, 0, 0, 0 };

            while (true)
            {
                Console.WriteLine("Tente descobrir a senha ****");

                for (int i = 0; i < listaNumeros.Length; i++)
                {
                    Console.WriteLine("Digito " + (i + 1));
                    numeros[i] = int.Parse(Console.ReadLine());

                    if (numeros[i] == listaNumeros[i])
                    {
                        Console.WriteLine("Digito correto");
                        if (i == listaNumeros.Length - 1)
                        {
                            Console.WriteLine("Senha correta");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Digito incorreto");
                        break;
                    }
                }

            }

            Console.WriteLine("Terminando");


        }
    }
}