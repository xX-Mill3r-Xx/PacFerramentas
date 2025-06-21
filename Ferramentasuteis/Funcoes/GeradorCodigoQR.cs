using QRCoder;
using System.Windows.Forms;

namespace Ferramentasuteis.Funcoes
{
    public static class GeradorCodigoQR
    {
        public static void GerarCodigoQR(TextBox txtCode, PictureBox picCode)
        {
            string codigicar = txtCode.Text;
            string generator = new string(codigicar.ToCharArray());

            string payload = generator.ToString();

            QRCodeGenerator qR_CodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qR_CodeGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qR = new QRCode(qRCodeData);
            picCode.Image = qR.GetGraphic(13);

            Reset(txtCode);
        }

        private static void Reset(TextBox txtCode)
        {
            txtCode.Text = string.Empty;
            txtCode.Focus();
        }
    }
}
