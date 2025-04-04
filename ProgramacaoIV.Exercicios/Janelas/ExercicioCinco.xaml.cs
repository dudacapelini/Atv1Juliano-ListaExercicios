using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
   
    public enum TipoUsuario 
    {
        [Description("Usuário com privilégios administrativos")]
        Administrador = 1,

        [Description("Usuário comum com permissões limitadas")]
        UsuarioComum = 2,

        [Description("Usuário visitante com acesso restrito")]
        Visitante = 3
    }

    public static class EnumExtensions 
    {
        public static string GetDescription(this Enum value) 
        {
            var field = value.GetType().GetField(value.ToString()); 
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute?.Description ?? value.ToString();  
        }
    }

    public partial class ExercicioCinco : Window
    {
        public ExercicioCinco()
        {
            InitializeComponent();
            DataContext = this; 
            ListaUsuarios = Enum.GetValues(typeof(TipoUsuario)).Cast<TipoUsuario>().ToList(); 
        }

        public List<TipoUsuario> ListaUsuarios { get; set; } 

        private void btnExibirEnum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cbItemEnum.SelectedItem is TipoUsuario usuarioSelecionado) 
                {
                    MessageBox.Show($"Descrição: {usuarioSelecionado.GetDescription()}");
                }
                else
                {
                    MessageBox.Show("Selecione um item antes de exibir!"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
