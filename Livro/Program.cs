using System;

namespace Livro
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Cria um objeto (instância) da classe Livro
            Livro meuLivro = new Livro("Acao Humana", "Ludwig von Mises", 2023);

            // 2. Chama o método para exibir as informações no console
            meuLivro.ExibirInformacoes();
        }
    }
}