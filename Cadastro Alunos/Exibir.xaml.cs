using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cadastro_Alunos
{
    /// <summary>
    /// Interaction logic for Exibir.xaml
    /// </summary>
    public partial class Exibir : Window
    {
        Cadastro cadastro;

        public Exibir(Cadastro cadastro)
        {
            InitializeComponent();

            this.cadastro = cadastro;

            ExibirLista();
        }

        void ExibirLista()
        {
            foreach (Aluno aluno in cadastro.alunos)
            {
                listafinal1.Items.Add(aluno.Nome);
            }

           
          
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
