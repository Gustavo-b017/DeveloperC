using Classes;
using System;
using System.Diagnostics;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de carros diversos
            var carList = new List<Carro>
            {
                new Carro(100001, "AAA-1111", "Preto", "1.0 Flex"),
                new Carro(100002, "BBB-2222", "Branco", "1.6 Diesel"),
                new Carro(100003, "CCC-3333", "Vermelho", "2.0 Turbo"),
                new Carro(100004, "DDD-4444", "Azul", "1.8 Flex"),
                new Carro(100005, "EEE-5555", "Prata", "2.2 Gasolina"),
                new Carro(100006, "FFF-6666", "Verde", "1.4 Flex"),
                new Carro(100007, "GGG-7777", "Amarelo", "2.0 Diesel"),
                new Carro(100008, "HHH-8888", "Cinza", "1.0 Turbo"),
                new Carro(100009, "III-9999", "Roxo", "1.6 Gasolina"),
                new Carro(100010, "JJJ-0000", "Laranja", "2.4 Flex")
            };

            Veiculo veiculo = new Veiculo(12);

            Veiculo.Ligar();

            veiculo.Placa = "ABC-1234";

            // Exibe os dados de cada carro chamando o construtor em cada iteração
            foreach (var carro in carList)
            {
                // Cria uma nova instância usando os mesmos dados do carro atual
                var novoCarro = new Carro(
                    carro.GetType().GetField("chassis", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(carro) is int ch ? ch : 0,
                    carro.GetType().GetField("licensePlate", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(carro) as string,
                    carro.GetType().GetField("color", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(carro) as string,
                    carro.GetType().GetField("motor", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(carro) as string
                );

                // Exibe os dados do novoCarro
                Console.WriteLine(
                    $"Chassis: {novoCarro.GetType().GetField("chassis", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(novoCarro)}, " +
                    $"Placa: {novoCarro.GetType().GetField("licensePlate", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(novoCarro)}, " +
                    $"Cor: {novoCarro.GetType().GetField("color", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(novoCarro)}, " +
                    $"Motor: {novoCarro.GetType().GetField("motor", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(novoCarro)}"
                );
            }
        }
    }
}
