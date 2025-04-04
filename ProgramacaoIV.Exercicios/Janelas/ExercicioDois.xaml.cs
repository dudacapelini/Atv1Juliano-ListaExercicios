using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    
    public partial class ExercicioDois : Window
    {
        public ExercicioDois()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var temperatura = Convert.ToInt32(txtConverter.Text);

                MessageBox.Show($"Resultado = {(temperatura * 9/5) + 32}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
