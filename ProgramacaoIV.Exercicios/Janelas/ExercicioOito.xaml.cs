using System;
using System.Windows;
using System.Windows.Controls;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public enum DiasDaSemana
    {
        Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado
    }

    public partial class ExercicioOito : Window
    {
        public ExercicioOito()
        {
            InitializeComponent();
        }

        private void btnVerificarDia_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate.HasValue)
            {
                DateTime dataSelecionada = datePicker.SelectedDate.Value;
                DiasDaSemana diaSemana = (DiasDaSemana)dataSelecionada.DayOfWeek;
                MessageBox.Show($"A data selecionada cai em: {diaSemana}", "Dia da Semana");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data.", "Erro");
            }
        }
    }
}
