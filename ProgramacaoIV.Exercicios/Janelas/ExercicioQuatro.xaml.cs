using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    
    public partial class ExercicioQuatro : Window
    {
        public ExercicioQuatro()
        {
            InitializeComponent();
        }

        private void btnVerificador_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var idade = Convert.ToInt32(txtVerificador.Text);


                if (idade >= 18)
                {
                    MessageBox.Show($"Voce é maior de idade!");
                }
                else
                {
                    MessageBox.Show($"Voce é menor de idade!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
