using System.Text.Json;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    
    public partial class ExercicioSete : Window
    {
        public ExercicioSete()
        {
            InitializeComponent();
        }

        private void btnCalcularPagamento_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var total = Convert.ToInt32(txtValorTotal.Text);
                var qntParcelas  = Convert.ToInt32(cbQuantidadeParcela.Text);

                var valorParcelado = (total / qntParcelas);

                MessageBox.Show($"Voce ira pagar "+ valorParcelado + "R$!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
