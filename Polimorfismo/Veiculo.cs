using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{

    // abstract class - não pode criar coisas diretamente dela
    abstract class Veiculo
    {
        protected string placa;
        protected string chassi;
        protected string cor;
        protected string motor;

        bool motorLigado;
        protected int pessoas;
        protected int capacidadePessoa;
        protected float estadoTanque;

        public void LigarMotor()
        {
            motorLigado = true;
            //Console.WriteLine("O motor do veículo de placa " + placa + " está ligado.");
        }

        public void DesligarMotor()
        {
            motorLigado = false;
        }

        public int EstadoTanque()
        {
            return (int)(estadoTanque * 100);
        }

        public void AdicionarPessoas(int pessoas)
        {
            if (pessoas > capacidadePessoa)
            {
                Console.WriteLine("Não é possível adicionar " + pessoas + " pessoas. Capacidade máxima é " + capacidadePessoa + ".");
            }

            this.pessoas += pessoas;
        }

        // método virtual - pode ser sobrescrito, mas não é obrigatório
        // método abstrato - deve ser sobrescrito em todas as classes filhas
        public virtual string VerificarPessoas()
        {
            return "Existe " + this.pessoas + " pessoas no " + this.GetType().Name + " contando com o motorrista";
        }
    }
}
