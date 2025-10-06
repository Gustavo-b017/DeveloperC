using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
    class Livro
    {
        // Propriedades da classe
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }

        // Construtor que inicializa as propriedades
        public Livro(string titulo, string autor, int anoPublicacao)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.AnoPublicacao = anoPublicacao;
        }

        // Método para exibir as informações formatadas
        public void ExibirInformacoes()
        {
            Console.WriteLine($"{this.Titulo} – {this.Autor} ({this.AnoPublicacao})");
        }
    }
}
