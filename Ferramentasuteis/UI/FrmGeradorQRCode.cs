using Ferramentasuteis.Funcoes;
using System;
using System.Windows.Forms;

namespace Ferramentasuteis.UI
{
    public partial class FrmGeradorQRCode : Form
    {
        public FrmGeradorQRCode()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                GeradorCodigoQR.GerarCodigoQR(txtCode, picCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
