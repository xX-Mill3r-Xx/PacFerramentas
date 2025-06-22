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

        private void btnGeradorDeQRCode_Click(object sender, EventArgs e)
        {
            FrmGeradorQRCode qrCode = new FrmGeradorQRCode();
            qrCode.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConversorpolegadas conversorPolegadas = new FrmConversorpolegadas();
            conversorPolegadas.Show();
        }
    }
}
