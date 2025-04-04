using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioSeis : Window
    {
        private int contador = 0;

        public ExercicioSeis()
        {
            InitializeComponent();
        }
        private void btnIncrementarContador_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                contador++;
                MessageBox.Show($"Número de cliques: {contador}", "Contador");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
