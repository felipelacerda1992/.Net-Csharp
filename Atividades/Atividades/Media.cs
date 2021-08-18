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
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencher nome.");
                txtNome.Focus();
            }
            else if (txtn1.Text == "" || txtn2.Text == "" || txtn3.Text == "" || txtn4.Text == "")
            {
                MessageBox.Show("Preencher todas as notas.");
            }
            else
            {
                Decimal n1;
                Decimal n2;
                Decimal n3;
                Decimal n4;
                Decimal media;
                n1 = Convert.ToDecimal(txtn1.Text);
                n2 = Convert.ToDecimal(txtn2.Text);
                n3 = Convert.ToDecimal(txtn3.Text);
                n4 = Convert.ToDecimal(txtn4.Text);

                if (n1 < 0 || n2 < 0 || n3 < 0 || n4 < 0)
                {
                    MessageBox.Show("O menor valor deve ser zero.");
                }
                else if (n1 > 100 || n2 > 100 || n3 > 100 || n4 > 100)
                {
                    MessageBox.Show("O maior valor de ser 100.");

                }
                else
                {

                    media = (n1 + n2 + n3 + n4) / 4;
                    //deixar o visible do label aqui
                    if (media <= 49)
                    {
                        lblMedia.Text = "Reprovado - Média: " + media;
                        lblMedia.ForeColor = System.Drawing.Color.Red;
                        lblMedia.Visible = true;
                    }
                    else if (media > 49 && media <= 69)
                    {
                        lblMedia.Text = "Exame - Média: " + media;
                        lblMedia.ForeColor = System.Drawing.Color.Orange;
                        lblMedia.Visible = true;
                    }
                    else
                    {
                        lblMedia.Text = "Aprovado - Média: " + media;
                        lblMedia.ForeColor = System.Drawing.Color.Green;
                        lblMedia.Visible = true;
                    }
                }
            }
        }
    }
}
