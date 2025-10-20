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
using System;
using System.Windows;

namespace Calculadora_WPF
{
    public partial class MainWindow : Window
    {
        CalculadoraCore core = new CalculadoraCore();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Somar_Click(object sender, RoutedEventArgs e)
        {
            ExecutarOperacao(core.Somar);
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            ExecutarOperacao(core.Subtrair);
        }

        private void Multiplicar_Click(object sender, RoutedEventArgs e)
        {
            ExecutarOperacao(core.Multiplicar);
        }

        private void Divisao_Click(object sender, RoutedEventArgs e)
        {
            ExecutarOperacao(core.Dividir);
        }

        // --- MÉTODO AUXILIAR PARA EVITAR REPETIÇÃO DE CÓDIGO ---

        /// <summary>
        /// Pega os valores da tela, executa a operação matemática e exibe o resultado.
        /// Trata erros de conversão ou de lógica (como divisão por zero).
        /// </summary>
        /// <param name="operacao">A função a ser executada (ex: core.Somar).</param>
        private void ExecutarOperacao(Func<double, double, double> operacao)
        {
            try
            {
                // 1. Converte o texto dos campos para double
                double valor1 = double.Parse(Campo1.Text);
                double valor2 = double.Parse(Campo2.Text);

                // 2. Executa a operação passada como parâmetro
                double resultado = operacao(valor1, valor2);

                // 3. Exibe o resultado na tela
                Resultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                // Erro se o usuário digitar texto inválido (ex: "abc")
                MessageBox.Show("Por favor, digite apenas números válidos nos campos.", "Erro de Entrada");
                Resultado.Text = "Erro";
            }
            catch (DivideByZeroException ex)
            {
                // Erro específico para divisão por zero
                MessageBox.Show(ex.Message, "Erro Matemático");
                Resultado.Text = "Erro";
            }
            catch (Exception ex)
            {
                // Captura qualquer outro erro inesperado
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro");
                Resultado.Text = "Erro";
            }
        }

        private void Campo2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}