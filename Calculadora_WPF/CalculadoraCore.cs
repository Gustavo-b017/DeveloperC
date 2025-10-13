using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_WPF
{
    internal class CalculadoraCore
    {
        double[] doubles;
        int index;

        public CalculadoraCore()
        {
            doubles = new double[8];
            index = 0;
        }

        /// <summary>
        /// Função que adiciona um numero ao buffer
        /// </summary>
        /// <param name="valor">valor que será armazenado</param>
        /// <returns>retorna false se buffer cheio</returns>
        public bool AdicionarBuffer(double valor)
        {
            if(index >= doubles.Length)
            {
                return false;
            }

            doubles[index] = valor;
            index++;
            return true;
        }

        public double Processor()
        {
            double sum = 0;
            foreach (double d in doubles)
            {
                sum += d;
            }
            return sum;
        }
    }
}
