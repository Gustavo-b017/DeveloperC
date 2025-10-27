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
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using PetRegistry.Models;

namespace PetRegistry
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Pets { get; } = new();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Adicionar_Click(object sender, RoutedEventArgs e)
        {
            var nome = NomeBox.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome.", "Validação", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(IdadeBox.Text?.Trim(), out var idade) || idade < 0)
            {
                MessageBox.Show("Idade inválida.", "Validação", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var tipo = (TipoCombo.SelectedItem as System.Windows.Controls.ComboBoxItem)?.Content?.ToString() ?? "Cachorro";

            Animal pet = tipo switch
            {
                "Gato" => new Cat(nome, idade),
                _ => new Dog(nome, idade)
            };

            Pets.Add(pet);

            // Limpar campos
            NomeBox.Text = "";
            IdadeBox.Text = "";
            TipoCombo.SelectedIndex = 0;
            NomeBox.Focus();
        }

        private void Remover_Click(object sender, RoutedEventArgs e)
        {
            if (PetsGrid.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um pet para remover.", "Remover", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            // Copiar seleção para lista temporária para evitar modificação durante a iteração
            var selecionados = PetsGrid.SelectedItems.Cast<Animal>().ToList();
            foreach (var a in selecionados)
            {
                Pets.Remove(a);
            }
        }

        private void Total_Click(object sender, RoutedEventArgs e)
        {
            decimal total = Pets.Sum(p => p.GetFee());
            var ptBr = new CultureInfo("pt-BR");
            MessageBox.Show($"Total das taxas: {total.ToString("C", ptBr)}", "Total", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void PetsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NomeBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}