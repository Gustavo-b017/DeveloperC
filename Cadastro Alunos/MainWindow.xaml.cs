using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cadastro_Alunos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Cadastro cadastro = new Cadastro();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Exibir exibir = new Exibir(cadastro);
           exibir.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (alunoNome.Text.Length > 3)
            {
                cadastro.Cadastrar(alunoNome.Text);
            }

            alunoNome.Text= "";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}