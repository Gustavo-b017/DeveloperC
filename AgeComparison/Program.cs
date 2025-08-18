using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age1, age2;

            Console.WriteLine("Insira a idade do aluno 1");
            age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a idade do aluno 2");
            age2 = int.Parse(Console.ReadLine());

            if (age1 == age2)
            {
                Console.WriteLine("O Aluno 1 tem as mesma idade do aluno 2");
            }
            if (age1 > age2)
            {
                Console.WriteLine("O Aluno 1 é mais velho que o Aluno 2");
            }
            if (age1 < age2)
            {
                Console.WriteLine("O Aluno 1 é mais novo que o Aluno 2");
            }


        }
    }
}