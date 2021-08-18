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
    public partial class frmBanco : Form
    {
        public frmBanco()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                BancoDAO objdao = new BancoDAO();
                tb_banco objBanco = new tb_banco();

                objBanco.codigo_banco = txtCodBanco.Text.Trim();
                objBanco.nome_banco = txtNomeBanco.Text.Trim();
                objBanco.id_usuario = Usuario.CodigoLogado;

                try
                {
                    if (txtIdBanco.Text == "")
                    {
                        objdao.SalvarBanco(objBanco);
                    }
                    else
                    {
                        objBanco.id_banco = Convert.ToInt32(txtIdBanco.Text);
                        objdao.AlterarBanco(objBanco);
                    }
                    LimparCampos();
                    MessageBox.Show("Banco salvo!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
                catch
                {

                    MessageBox.Show("Ocorreu um erro na operação. Tente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtCodBanco.Text.Trim() == "")
            {
                ret = false;
                campos = "- Código do Banco\n";
            }

            if (txtNomeBanco.Text.Trim() == "")
            {
                ret = false;
                campos = "- Nome do Banco";
            }

            if (ret == false)
            {
                MessageBox.Show("Preencher o(s) campo(s): \n\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ret;
        }

        private void CarregarGrid()
        {
            BancoDAO objdao = new BancoDAO();
            List<tb_banco> listaBanco = objdao.ConsultarBanco(Usuario.CodigoLogado);

            grdBanco.DataSource = listaBanco;

            grdBanco.Columns["id_banco"].Visible = false;
            grdBanco.Columns["id_usuario"].Visible = false;
            grdBanco.Columns["tb_usuario"].Visible = false;
            grdBanco.Columns["tb_conta"].Visible = false;

            grdBanco.Columns["nome_banco"].HeaderText = "Banco";
            grdBanco.Columns["codigo_banco"].HeaderText = "Codigo";
        }

        private void LimparCampos()
        {
            txtIdBanco.Clear();
            txtCodBanco.Clear();
            txtNomeBanco.Clear();

            btnExcluir.Visible = false;
            btnSalvar.Text = "Cadastrar";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarGrid();
        }

        private void GrdBanco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdBanco.RowCount > 0)
            {
                tb_banco objLinhaClick = (tb_banco)grdBanco.CurrentRow.DataBoundItem;

                txtIdBanco.Text = Convert.ToString(objLinhaClick.id_banco);
                txtNomeBanco.Text = objLinhaClick.nome_banco;
                txtCodBanco.Text = objLinhaClick.codigo_banco;

                btnExcluir.Visible = true;
                btnSalvar.Text = "Alterar";

            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codBanco = Convert.ToInt32(txtIdBanco.Text);
                BancoDAO objdao = new BancoDAO();

                objdao.ExcluirBanco(codBanco);

                MessageBox.Show("O banco foi excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarGrid();
            }
            catch
            {

                MessageBox.Show("O registro não pôde ser excluído.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
