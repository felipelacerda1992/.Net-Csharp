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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidarCampos() == true)
            {
                CategoriaDAO objdao = new CategoriaDAO();
                tb_categoria objCategoria = new tb_categoria();

                objCategoria.nome_categoria = txtCategoria.Text.Trim();
                objCategoria.id_usuario = Usuario.CodigoLogado;

                try
                {
                    if (txtIdcategoria.Text == "") //se é inserção
                    {
                        objdao.SalvarCategoria(objCategoria);
                    }
                    else // se é alteração
                    {
                        objCategoria.id_categoria = Convert.ToInt32(txtIdcategoria.Text);
                        objdao.AlterarCategoria(objCategoria);
                    }
                    LimparCampos();
                    MessageBox.Show("Categoria salva!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                    
                }
                catch 
                {

                    MessageBox.Show("Ocorreu um erro na operação. Tente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int codCategoria = Convert.ToInt32(txtIdcategoria.Text);
                CategoriaDAO objdao = new CategoriaDAO();

                objdao.ExcluirCategoria(codCategoria);

                MessageBox.Show("A categoria foi excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregarGrid();
            }
            catch
            {

                MessageBox.Show("O registro não pôde ser excluído.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;

            if (txtCategoria.Text.Trim() == "")
            {
                ret = false;
            }

            if (ret == false)
            {
                MessageBox.Show("Preencher o campo: \n\n - Categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ret;
            
        }

        private void CarregarGrid()
        {
            CategoriaDAO objdao = new CategoriaDAO();
            List<tb_categoria> listaCategoria = objdao.ConsultarCategoria(Usuario.CodigoLogado);

            grdCategorias.DataSource = listaCategoria;

            grdCategorias.Columns["id_categoria"].Visible = false;
            grdCategorias.Columns["id_usuario"].Visible = false;
            grdCategorias.Columns["tb_usuario"].Visible = false;
            grdCategorias.Columns["tb_movimento"].Visible = false;

            grdCategorias.Columns["nome_categoria"].HeaderText = "Categoria";
        }

        private void LimparCampos()
        {
            txtIdcategoria.Clear();
            txtCategoria.Clear();

            btnExcluir.Visible = false;
            btnSalvar.Text = "Cadastrar";
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarGrid();
        }

        private void GrdCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCategorias.RowCount > 0)
            {
                tb_categoria objLinhaClick = (tb_categoria)grdCategorias.CurrentRow.DataBoundItem;

                txtIdcategoria.Text = Convert.ToString(objLinhaClick.id_categoria);
                txtCategoria.Text = objLinhaClick.nome_categoria;

                btnExcluir.Visible = true;
                btnSalvar.Text = "Alterar";
            }
        }

        
    }
}
