using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financeiro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnNovaConta_Click(object sender, EventArgs e)
        {
            frmCadastro frm = new frmCadastro();
            frm.ShowDialog();
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            UsuarioDAO objdao = new UsuarioDAO();
            int codUser = objdao.ValidarLogin(txtSenha.Text.Trim(), txtEmail.Text.Trim());

            if (codUser == -2)
            {
                MessageBox.Show("Usuário não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario.CodigoLogado = codUser;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos = "- Email\n";
            }

            if (txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos = "- Senha\n";
            }

            
            

            if (ret == false)
            {
                MessageBox.Show("Preencher o(s) campo(s): \n\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ret;
        }
    }
}
