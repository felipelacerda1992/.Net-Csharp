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
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                ContaDAO objdao = new ContaDAO();
                tb_conta objConta = new tb_conta();

                objConta.agencia_conta = txtAgencia.Text.Trim();
                objConta.numero_conta = txtNumConta.Text.Trim();
                objConta.saldo_conta = Convert.ToDecimal(txtSaldoConta.Text);
                objConta.status_conta = ckbStatus.Checked;
                objConta.id_banco = (int)cbbBanco.SelectedValue;
                objConta.id_usuario = Usuario.CodigoLogado;

                try
                {
                    if (txtIdConta.Text == "") //se é inserção
                    {
                        objdao.SalvarConta(objConta);
                    }
                    else // se é alteração
                    {
                        objConta.id_conta = Convert.ToInt32(txtIdConta.Text);
                        objdao.AlterarConta(objConta);
                    }
                    LimparCampos();
                    MessageBox.Show("Conta salva!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (txtAgencia.Text.Trim() == "")
            {
                ret = false;
                campos = "- Agencia\n";
            }

            if (txtNumConta.Text.Trim() == "")
            {
                ret = false;
                campos = "- Número da conta\n";
            }

            if (txtSaldoConta.Text.Trim() == "")
            {
                ret = false;
                campos = "- Saldo da Conta\n";
            }

            if (cbbBanco.SelectedIndex == -1)
            {
                ret = false;
                campos = campos + "- Banco";
            }

            if (ret == false)
            {
                MessageBox.Show("Preencher o(s) campo(s): \n\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ret;
        }

        private void LimparCampos()
        {
            txtIdConta.Clear();
            cbbBanco.SelectedIndex = -1;
            txtNumConta.Clear();
            txtAgencia.Clear();
            txtSaldoConta.Clear();
            ckbStatus.Checked = true;

            btnExcluir.Visible = false;
            btnSalvar.Text = "Cadastrar";
        }

        private void FrmConta_Load(object sender, EventArgs e)
        {
            CarregarBanco();
            CarregarGrid();
            LimparCampos();
        }

        private void CarregarBanco()
        {
            BancoDAO objdao = new BancoDAO();
            List<tb_banco> listaBancos = objdao.ConsultarBanco(Usuario.CodigoLogado);
            cbbBanco.DataSource = listaBancos;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            { 
              int codConta = Convert.ToInt32(txtIdConta.Text);
              ContaDAO objdao = new ContaDAO();

              objdao.ExcluirConta(codConta);

              MessageBox.Show("A conta foi excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
              LimparCampos();
              CarregarGrid();
            }
            catch
            {

                MessageBox.Show("O registro não pôde ser excluído.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            ContaDAO objdao = new ContaDAO();
            List<tb_conta> listaConta = objdao.ConsultarConta(Usuario.CodigoLogado);

            grdConta.DataSource = listaConta;

            grdConta.Columns["id_conta"].Visible = false;
            grdConta.Columns["id_usuario"].Visible = false;
            grdConta.Columns["id_banco"].Visible = false;
            grdConta.Columns["tb_usuario"].Visible = false;
            grdConta.Columns["tb_movimento"].Visible = false;
            grdConta.Columns["tb_banco"].Visible = false;


            grdConta.Columns["agencia_conta"].HeaderText = "Agencia";
            grdConta.Columns["numero_conta"].HeaderText = "Numero";
            grdConta.Columns["saldo_conta"].HeaderText = "Saldo";
            grdConta.Columns["status_conta"].HeaderText = "Status";
        }

        private void GrdConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdConta.RowCount > 0)
            {
                tb_conta objLinhaClick = (tb_conta)grdConta.CurrentRow.DataBoundItem;

                txtIdConta.Text = Convert.ToString(objLinhaClick.id_conta);
                txtAgencia.Text = objLinhaClick.agencia_conta;
                txtNumConta.Text = objLinhaClick.numero_conta;
                txtSaldoConta.Text = Convert.ToString(objLinhaClick.saldo_conta);
                ckbStatus.Checked = objLinhaClick.status_conta;
                cbbBanco.SelectedValue = objLinhaClick.id_banco;
                btnExcluir.Visible = true;
                btnSalvar.Text = "Alterar";
            }
        }
    }

}
