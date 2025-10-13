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

namespace Calculadora_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculadoraCore core = new CalculadoraCore();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textoSaida_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double valor = core.Processor();

            testeSaida.Text = valor.ToString();
        }


        private void CampoEntrada_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnBuffer_Click_1(object sender, RoutedEventArgs e)
        {
            double valor;

            if (double.TryParse(CampoEntrada.Text, out valor))
            {


                if (core.AdicionarBuffer(valor))
                {
                    conteudo.Text += valor.ToString() + "\n";
                    CampoEntrada.Text = "";
                }
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            core = new CalculadoraCore();
            CampoEntrada.Text = string.Empty;
            conteudo.Text = string.Empty;
            testeSaida.Text = string.Empty;
        }
    }
}