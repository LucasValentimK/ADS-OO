﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeira_Aula
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 + n2;
            lblResultado.Text = "Seu resultado é:" + resultado.ToString();
         }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
