using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WPF
{
    internal class CalculadoraCore
    {
        public double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                // Lança uma exceção específica para divisão por zero
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return valor1 / valor2;
        }
    }
}
