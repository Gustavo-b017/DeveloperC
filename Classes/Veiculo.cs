using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Veiculo
    {
        // private, somente a propria classe tem acesso
        // public, qualquer classe tem acesso
        // protected, somente a propria classe e as classes filhas tem acesso
        // constuctor, metodo especial para inicializar o objeto, que tem o mesmo nome da classe e incia quando chama o projeto

        private string placa;

        private int codFabrica;

        // Construtor
        public Veiculo(int codFabrica)
        {
            this.codFabrica = codFabrica;
        }

        public string Placa { get => placa; set => placa = value; }

        public static void Ligar()
        {
            Console.WriteLine("Lingando...");
        }

        //public void setPlaca(string placa)
        //{
        //    this.placa = placa;
        //}
    }
}
