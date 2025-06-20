using Ferramentasuteis.Funcoes;
using System;
using System.Windows.Forms;

namespace Ferramentasuteis.UI
{
    public partial class FrmGeradorDeSenhas : Form
    {
        public FrmGeradorDeSenhas()
        {
            InitializeComponent();
        }

        private void FrmGeradorDeSenhas_Load(object sender, EventArgs e)
        {
            GeradorDeSenhas.CarregarComboboxForcaSenha(cbForcaSenha);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                GeradorDeSenhas.RetornaSenhaGerada(cbForcaSenha, lbSenha);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CopiarSenha()
        {
            if (!string.IsNullOrEmpty(lbSenha.Text))
            {
                Clipboard.SetText(lbSenha.Text);
                MessageBox.Show("Senha copiada para area de transferencia!");
            }
            else
            {
                MessageBox.Show("Não há senha para copiar.");
            }
        }

        private void btnCopiarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                CopiarSenha();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
