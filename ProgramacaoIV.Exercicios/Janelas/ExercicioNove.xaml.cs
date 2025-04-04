using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public partial class ExercicioNove : Window
    {
        private bool estaLigado = false;

        public ExercicioNove()
        {
            InitializeComponent();
        }
        private void btnToggle_Click(object sender, RoutedEventArgs e)
        {
            estaLigado = !estaLigado;
            string estado = estaLigado ? "Ligado" : "Desligado";

            btnToggle.Content = estado;
            MessageBox.Show($"O estado atual é: {estado}", "Interruptor");
        }
    }
}
