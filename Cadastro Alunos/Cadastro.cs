using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Alunos
{
    public class Cadastro
    {

        public List<Aluno> alunos = new List<Aluno>();

        int contadorMatricula = 0;



        public Cadastro()
        {
            

        }
        public void Cadastrar(string nome)
        {
            
            int matricula = contadorMatricula ;
            alunos.Add(new Aluno(nome,matricula));
            contadorMatricula++;
         
        }

        public List<Aluno> ExibirLista()
        {
            return alunos;

        }

    }
}
