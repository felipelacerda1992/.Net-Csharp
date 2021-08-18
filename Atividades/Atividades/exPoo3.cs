using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades
{
    public partial class exPoo3 : Form
    {
        public exPoo3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Decimal qtd5 =0;
            Decimal qtd6 =0;
            Decimal qtd7 =0;
            bool chb5 = false;
            bool chb6 = false;
            bool chb7 = false;



            if (cb5.Checked = true)
            {
                qtd5 = Convert.ToDecimal(txtQ5.Text);
                chb5 = true;
            }
            else if (cb6.Checked = true)
            {
                qtd6 = Convert.ToDecimal(txtQ6.Text);
                chb6 = true;
            }
            else
            {
                qtd7 = Convert.ToDecimal(txtQ7.Text);
                chb7 = true;
            }

            VerificarClass verifPreco = new VerificarClass();
            lbltotal.Visible = true;
            lbltotal.Text = "O preço é: " + verifPreco.VerificaPreco(qtd5, qtd6, qtd7, chb5, chb6, chb7);
            


        }
    }
}
