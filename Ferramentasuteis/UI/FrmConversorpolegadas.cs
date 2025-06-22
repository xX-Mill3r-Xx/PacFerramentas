using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentasuteis.UI
{
    public partial class FrmConversorpolegadas : Form
    {
        public FrmConversorpolegadas()
        {
            InitializeComponent();
        }

        private void Converter()
        {
            try
            {
                double centimetros = double.Parse(txtValor.Text);
                double polegadas;
                polegadas = centimetros * 2.54;
                lb_Polegadas.ForeColor = Color.Green;

                lb_Polegadas.Text = $"Equivlem a {polegadas.ToString(CultureInfo.InvariantCulture)} Centimetos";

                lb_Centimetros.ForeColor = Color.Blue;
                lb_Centimetros.Text = $"{centimetros.ToString(CultureInfo.InvariantCulture)} Polegadas";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            Converter();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Converter();
            }
        }
    }
}
