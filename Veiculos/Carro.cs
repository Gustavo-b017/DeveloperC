using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    // Classe derivada que herda de Veiculo.
    internal class Carro : Veiculo
    {
        string modelo;

        public Carro(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoa = 4;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.motor = motor;
            Random random = new Random();
            chassi = random.Next().ToString("00000000000000000");
        }

        // Sobrescreve o método Acelerar com um comportamento específico para Carro.
        public override void Acelerar()
        {
            Console.WriteLine("Carro acelerando rapidamente...");
        }
    }
}