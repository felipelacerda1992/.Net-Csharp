using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace Financeiro
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos() == true)
            {
                UsuarioDAO objdao = new UsuarioDAO();
                tb_usuario objUsuario = new tb_usuario();

                objUsuario.nome_usuario = txtNome.Text.Trim();
                objUsuario.email_usuario = txtEmail.Text.Trim();
                objUsuario.senha_usuario = txtSenha.Text.Trim();
                objUsuario.data_cadastro = DateTime.Now;

                try
                {
                    objdao.FinalizarCadastro(objUsuario);
                    MessageBox.Show("Cadastro realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {

                    MessageBox.Show("Ocorreu um erro na operação. Tente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if(txtNome.Text.Trim() == "")
            {
                ret = false;
                campos = "- Nome\n";
            }

            if(txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos = campos + "- Email\n";
            }

            if(txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos = campos + "- Senha";
            }
            else if (txtSenha.Text.Trim() != txtRsenha.Text.Trim())
            {
                ret = false;
                campos = campos + "- Senha e repetir senha não conferem";
            }

            if (ret == false)
            {
                MessageBox.Show("Preencher o(s) campo(s): \n\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ret;
        }
    }
}
