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
    public partial class frmConsultarMovimento : Form
    {
        public frmConsultarMovimento()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            MovimentoDAO objdao = new MovimentoDAO();

            List<MovimentoVO> listaMov = objdao.ConsultarMovimento(Usuario.CodigoLogado, 
                                                                   cmbTipo.SelectedIndex, 
                                                                   dtpInicial.Value.Date, 
                                                                   dtpFinal.Value.Date);

            if (listaMov.Count == 0)
            {
                MessageBox.Show("Não foi encontrado nenhum registro", "Resultado", MessageBoxButtons.OK);
                grdPesquisa.DataSource = null;
                lblTotal.Visible = false;
            }
            else
            {

                decimal total = 0;
                for (int i = 0; i < listaMov.Count; i++)
                {
                    if (listaMov[i].Tipo == "Saída")
                    {
                        total -= listaMov[i].Valor;
                    }
                    else
                    {
                        total += listaMov[i].Valor;
                    }
                    
                }

                lblTotal.Text = "Total: R$" + total;
                lblTotal.Visible = true;
                grdPesquisa.DataSource = listaMov;
            }


        }

        private void FrmConsultarMovimento_Load(object sender, EventArgs e)
        {
            cmbTipo.SelectedIndex = 2;
            lblTotal.Visible = false;
        }
    }
}
