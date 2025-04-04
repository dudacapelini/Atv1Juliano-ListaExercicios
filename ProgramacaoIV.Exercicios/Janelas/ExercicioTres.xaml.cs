using System.Net.NetworkInformation;
using System.Windows;


namespace ProgramacaoIV.Exercicios.Janelas
{
    
    public partial class ExercicioTres : Window
    {
        public ExercicioTres()
        {
            InitializeComponent();
        }

        private void btnDiferenca_Click(object sender, RoutedEventArgs e)
        {
             
            try
            {
                DateTime dataNascimento = dpAniversario.SelectedDate.Value;
                DateTime hoje = DateTime.Today;

                DateTime proxAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

                int DiasFaltando = (proxAniversario - hoje).Days;

                MessageBox.Show($"Faltam = {DiasFaltando} dias para o próximo aniversário!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
