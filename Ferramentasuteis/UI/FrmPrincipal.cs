using Ferramentasuteis.UI;
using System;
using System.Windows.Forms;

namespace Ferramentasuteis
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGeradorDeSenhas_Click(object sender, EventArgs e)
        {
            FrmGeradorDeSenhas senhas = new FrmGeradorDeSenhas();
            senhas.Show();
        }
    }
}
