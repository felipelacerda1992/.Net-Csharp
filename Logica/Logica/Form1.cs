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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtN1.Text == "")
                MessageBox.Show("Preencher campo número 1!");
            else if (txtN2.Text == "")
                MessageBox.Show("Preencher campo número 2!");
            else
            {
                Decimal n1;
                Decimal n2;
                Decimal soma;

                n1 = Convert.ToDecimal(txtN1.Text);
                n2 = Convert.ToDecimal(txtN2.Text);

                soma = n1 + n2;

                txtResultado.Text = Convert.ToString(soma);



            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtN4.Text == "")
                MessageBox.Show("Preencher campo número 3!");
            else if (txtN4.Text == "")
                MessageBox.Show("Preencher campo número 4!");
            else
            {
                Decimal n3;
                Decimal n4;
                Decimal multiplica;

                n3 = Convert.ToDecimal(txtN3.Text);
                n4 = Convert.ToDecimal(txtN4.Text);

                multiplica = n3 * n4;

                txtResultado2.Text = Convert.ToString(multiplica);

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (txtN5.Text == "")
                MessageBox.Show("Preencher campo número 5!");
            else if (txtN6.Text == "")
                MessageBox.Show("Preencher campo número 6!");
            else
            {
                Decimal n5;
                Decimal n6;
                Decimal diminuir;

                n5 = Convert.ToDecimal(txtN5.Text);
                n6 = Convert.ToDecimal(txtN6.Text);

                diminuir = n5 - n6;

                txtResultado3.Text = Convert.ToString(diminuir);

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtN7.Text == "")
                MessageBox.Show("Preencher o campo número 7");
            if (txtN8.Text == "")
                MessageBox.Show("Preencher o campo número 8");
            else 
            {
                Decimal n7 = Convert.ToDecimal(txtN7.Text);
                Decimal n8 = Convert.ToDecimal(txtN8.Text);

                Decimal divisao = n7 / n8;

                txtResultado4.Text = Convert.ToString(divisao);


            }
        }
    }
}
