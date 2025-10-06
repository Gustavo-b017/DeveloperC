using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    // Classe derivada que herda de Veiculo.
    internal class Caminhao : Veiculo
    {
        string modelo;
        public Caminhao(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoa = 3;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.motor = motor;
            Random random = new Random();
            chassi = random.Next().ToString("00000000000000000");
        }

        // Sobrescreve o método Acelerar com um comportamento específico para Caminhao.
        public override void Acelerar()
        {
            Console.WriteLine("Caminhão acelerando lentamente com carga pesada...");
        }
    }
}