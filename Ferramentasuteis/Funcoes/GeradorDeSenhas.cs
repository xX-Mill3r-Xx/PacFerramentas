using Ferramentasuteis.Enumeradores;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Ferramentasuteis.Funcoes
{
    public static class GeradorDeSenhas
    {
        public static string CaracteresPossiveis()
        {
            string senha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "123456789" +
                "#@%$!&";
            return senha;
        }

        public static void RetornaSenhaGerada(ComboBox cbForcaSenha, Label lbSenha)
        {
            string senha = CaracteresPossiveis();

            if (cbForcaSenha.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione a força da senha!");
                return;
            }

            EnumForcaSenha forca = (EnumForcaSenha)cbForcaSenha.SelectedValue;
            int comprimentoSenha = (int)forca;

            Random rn = new Random();
            int numeroSorteado = 0;
            StringBuilder passworld = new StringBuilder();
            for (int i = 0; i < comprimentoSenha; i++)
            {
                numeroSorteado = rn.Next(0, senha.Length - 1);
                passworld.Append(senha[numeroSorteado]);
            }

            lbSenha.Text = passworld.ToString();
        }

        public static void CarregarComboboxForcaSenha(ComboBox cbForcaSenha)
        {
            cbForcaSenha.Items.Clear();
            var forcaSenha = Enum.GetValues(typeof(EnumForcaSenha)).Cast<EnumForcaSenha>();
            var dataSource = forcaSenha.Select(fs => new
            {
                Description = ObterDescricaoEnumerador(fs),
                Value = fs
            }).ToList();

            cbForcaSenha.DataSource = dataSource;
            cbForcaSenha.DisplayMember = "Description";
            cbForcaSenha.ValueMember = "Value";
        }

        private static string ObterDescricaoEnumerador(Enum valor)
        {
            FieldInfo fi = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute[] atributos = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (atributos != null && atributos.Length > 0)
            {
                return atributos[0].Description;
            }
            else
            {
                return valor.ToString();
            }
        }
    }
}
