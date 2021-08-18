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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                EmpresaDAO objdao = new EmpresaDAO();
                tb_empresa objEmpresa = new tb_empresa();

                objEmpresa.nome_empresa = txtNomeEmpresa.Text.Trim();
                objEmpresa.endereco_empresa = txtEnderecoEmpresa.Text.Trim();
                objEmpresa.telefone_empresa = txtTelEmpresa.Text.Trim();
                objEmpresa.id_usuario = Usuario.CodigoLogado;

                try
                {
                    objdao.SalvarEmpresa(objEmpresa);
                    MessageBox.Show("Empresa salva!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (txtNomeEmpresa.Text.Trim() == "")
            {
                ret = false;
                campos = "- Nome empresa \n";
            }

            if (txtEnderecoEmpresa.Text.Trim() == "")
            {
                ret = false;
                campos = campos + "- Endereço empresa\n";
            }

            if (txtTelEmpresa.Text.Trim() == "")
            {
                ret = false;
                campos = campos + "- Telefone empresa";
            }

            if (ret == false)
            {
                MessageBox.Show("Preencher o(s) campo(s): \n\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ret;
        }

        private void CarregarGrid()
        {
            EmpresaDAO objdao = new EmpresaDAO();
            List<tb_empresa> listaEmpresa = objdao.ConsultarEmpresa(Usuario.CodigoLogado);

            grdEmpresa.DataSource = listaEmpresa;

            grdEmpresa.Columns["id_empresa"].Visible = false;
            grdEmpresa.Columns["id_usuario"].Visible = false;
            grdEmpresa.Columns["tb_usuario"].Visible = false;
            grdEmpresa.Columns["tb_movimento"].Visible = false;
            grdEmpresa.Columns["telefone_empresa"].Visible = false;
            grdEmpresa.Columns["endereco_empresa"].Visible = false;


            grdEmpresa.Columns["nome_empresa"].HeaderText = "Empresa";
        }

        private void GrdEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdEmpresa.RowCount > 0)
            {
                tb_empresa objLinhaClick = (tb_empresa)grdEmpresa.CurrentRow.DataBoundItem;

                txtIdEmpresa.Text = Convert.ToString(objLinhaClick.id_empresa);
                txtNomeEmpresa.Text = objLinhaClick.nome_empresa;
                txtEnderecoEmpresa.Text = objLinhaClick.endereco_empresa;
                txtTelEmpresa.Text = objLinhaClick.telefone_empresa;

                btnExcluir.Visible = true;
                btnSalvar.Text = "Alterar";
            }
        }

        private void LimparCampos()
        {
            txtIdEmpresa.Clear();
            txtNomeEmpresa.Clear();
            txtTelEmpresa.Clear();
            txtEnderecoEmpresa.Clear();

            btnExcluir.Visible = false;
            btnSalvar.Text = "Cadastrar";
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarGrid();
        }
    }
}
