using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Primeira_Aula
{
    public partial class frmAtividade : Form
    {
        public frmAtividade()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimerioNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 + n2;
            lblResultado.Text = "Seu resultado é:" + resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimerioNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 / n2;
            lblResultado.Text = "Seu resultado é:" + resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimerioNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 - n2;
            lblResultado.Text = "Seu resultado é:" + resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimerioNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 * n2;
            lblResultado.Text = "Seu resultado é:" + resultado.ToString();
        }
    }
}
