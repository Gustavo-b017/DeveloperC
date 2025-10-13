using Veiculos;
using System;
using System.Collections.Generic; // Habilita o uso de List<T>

namespace Veiculos
{
    internal class Program
    {
        // Ponto de entrada da aplicação.
        static void Main(string[] args)
        {
            // 1. Cria uma coleção (Lista) do tipo da classe base (Veiculo).
            List<Veiculo> veiculos = new List<Veiculo>();

            // 2. Adiciona objetos de diferentes classes derivadas na mesma lista.
            veiculos.Add(new Carro("ABC1234", "Gol", "Prata", "1.0"));
            veiculos.Add(new Caminhao("DEF5678", "Volvo FH", "Branco", "13L"));
            veiculos.Add(new Moto("GHI9876", "Hornet", "Dourada", "600cc"));

            // 3. Percorre a lista e chama o mesmo método (Acelerar) para cada objeto.
            // O polimorfismo garante que a versão correta do método seja executada
            // para cada tipo de objeto.
            foreach (Veiculo v in veiculos)
            {
                v.Acelerar();
            }
        }
    }
}