using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    // Classe base abstrata que serve como modelo para outros veículos.
    abstract class Veiculo
    {
        protected string placa;
        protected string chassi;
        protected string cor;
        protected string motor;
        protected int pessoas;
        protected int capacidadePessoa;

        // Método virtual que pode ser sobrescrito pelas classes filhas.
        // Fornece um comportamento padrão.
        public virtual void Acelerar()
        {
            Console.WriteLine("Veículo acelerando...");
        }
    }
}
