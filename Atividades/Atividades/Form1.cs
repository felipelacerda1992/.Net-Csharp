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
    public partial class frmTarefa : Form
    {
        public frmTarefa()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Preencher campo.");
                txtCodigo.Focus();
            }
            else if (txtNempresa.Text == "")
            {
                MessageBox.Show("Preencher campo.");
                txtNempresa.Focus();
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Preencher campo.");
                txtTel.Focus();
            }
            else if (txtNempresa.TextLength == 1 || txtNempresa.TextLength == 2)
            {
                MessageBox.Show("Deve ter mais caracteres.");
                txtNempresa.Focus();
            }
            else if (txtResponsavel.Text != "" && txtResponsavel.TextLength < 4)
            {
                MessageBox.Show("Deve conter mais caracteres.");
                txtResponsavel.Focus();
            }
            else
            {
                MessageBox.Show("Código: " + txtCodigo.Text + " / Nome da Empresa: " + txtNempresa.Text + 
                    " / Nome fantasia:" + txtNfantasia.Text + "\n\n Rua e número " + txtRua.Text + " " + txtNumero.Text +
                    "\n\n Telefone e Resonsável: " + txtTel.Text + " " + txtResponsavel.Text);
            }
        }
    }
}
