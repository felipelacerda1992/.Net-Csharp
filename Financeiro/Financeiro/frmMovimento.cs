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
    public partial class frmMovimento : Form
    {
        public frmMovimento()
        {
            InitializeComponent();
        }

        private void CarregarConta()
        {
           // cmbConta.DataSource = new ContaDAO().ConsultarConta(Usuario.CodigoLogado);
            ContaDAO objdao = new ContaDAO();
            List<tb_conta> listaConta = objdao.ConsultarContaAtiva(Usuario.CodigoLogado);
            cmbConta.DataSource = listaConta;
        }

        private void CarregarCategoria()
        {
            CategoriaDAO objdao = new CategoriaDAO();
            List<tb_categoria> listaCategoria = objdao.ConsultarCategoria(Usuario.CodigoLogado);
            cmbCategoria.DataSource = listaCategoria;
        }

        private void CarregarEmpresa()
        {
            EmpresaDAO objdao = new EmpresaDAO();
            List<tb_empresa> listaEmpresa = objdao.ConsultarEmpresa(Usuario.CodigoLogado);
            cmbEmpresa.DataSource = listaEmpresa;
        }

        private void LimparCampos()
        {
            txtObservacao.Clear();
            txtValor.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbConta.SelectedIndex = -1;
            cmbEmpresa.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            dtpData.Value = DateTime.Now;
            

           // btnExcluir.Visible = false;
           // btnSalvar.Text = "Cadastrar";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void FrmMovimento_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarConta();
            CarregarEmpresa();
            LimparCampos();
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if(cmbTipo.SelectedIndex == -1)
            {
                ret = false;
                campos = "- Tipo\n";
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                ret = false;
                campos = "- Categoria\n";
            }

            if (cmbConta.SelectedIndex == -1)
            {
                ret = false;
                campos = "- Conta\n";
            }

            if (cmbEmpresa.SelectedIndex == -1)
            {
                ret = false;
                campos = "- Empresa\n";
            }

            if (txtObservacao.Text.Trim() == "")
            {
                ret = false;
                campos = "- Observação\n";
            }

            if (txtValor.Text.Trim() == "")
            {
                ret = false;
                campos = "- Valor\n";
            }

            if (ret == false)
            {
                MessageBox.Show("Preencher o(s) campo(s): \n\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ret;
        }

        private void BtnLancar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                MovimentoDAO objdao = new MovimentoDAO();
                tb_movimento objMov = new tb_movimento();

                objMov.id_usuario = Usuario.CodigoLogado;
                objMov.valor_movimento = Convert.ToDecimal(txtValor.Text);
                objMov.obs_movimento = txtObservacao.Text.Trim();
                objMov.id_categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                objMov.id_conta = Convert.ToInt32(cmbConta.SelectedValue);
                objMov.id_empresa = Convert.ToInt32(cmbEmpresa.SelectedValue);
                objMov.tipo_movimento = Convert.ToInt16(cmbTipo.SelectedIndex);
                objMov.data_movimento = dtpData.Value;
                

                try
                {
                    
                    objdao.SalvarMovimento(objMov);

                    LimparCampos();
                    MessageBox.Show("Movimento salvo!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                catch
                {

                    MessageBox.Show("Ocorreu um erro na operação. Tente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
