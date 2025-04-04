using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public enum ResultadoSorteio
    {
        Perdeu,
        Ganhou
    }

    public partial class ExercicioDez : Window
    {
        private Random random = new Random();

        public ExercicioDez()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int numeroSorteado = random.Next(1, 7);

            ResultadoSorteio resultado = (numeroSorteado == 6) ? ResultadoSorteio.Ganhou : ResultadoSorteio.Perdeu;

            string mensagem = resultado == ResultadoSorteio.Ganhou ? "Você ganhou!" : "Tente novamente!";

            MessageBox.Show($"Número sorteado: {numeroSorteado}\n{mensagem}", "Resultado do Sorteio");
        }
    }
}
