using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void BtnImc_Click(object sender, EventArgs e)
        {
            Decimal p;
            Decimal a;
            Decimal i;

            a = Convert.ToDecimal(txtAltura.Text);
            p = Convert.ToDecimal(txtPeso.Text);

            i = CalculoImc(p, a);

            txtImc.Text = Convert.ToString(i);
        }

        private Decimal CalculoImc(Decimal peso, Decimal altura)
        {
            Decimal imc;

            imc = peso / (altura * altura);

            return imc;
        }

    }
}
