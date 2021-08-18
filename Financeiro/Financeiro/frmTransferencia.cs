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
    public partial class frmTransferencia : Form
    {
        public frmTransferencia()
        {
            InitializeComponent();
        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                MovimentoDAO objdao = new MovimentoDAO();

                objdao.SalvarTransferencia(Convert.ToInt32(cbbEntrada.SelectedValue),
                                            Convert.ToInt32(cbbSaida.SelectedValue),
                                            Convert.ToDecimal(txtValor.Text));
                MessageBox.Show("Transferencia realizada com sucesso!", "Sucesso", MessageBoxButtons.OK);
                LimparCampos();
            }
            catch 
            {

                MessageBox.Show("Ocorreu um erro na operação. Tente mais tarde!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTransferencia_Load(object sender, EventArgs e)
        {
            CarregarCombo();
            LimparCampos();
        }

        private void CarregarCombo()
        {
            cbbEntrada.DataSource = new ContaDAO().ConsultarContaAtiva(Usuario.CodigoLogado);
            cbbSaida.DataSource = new ContaDAO().ConsultarContaAtiva(Usuario.CodigoLogado);
        }

        private void LimparCampos()
        {
            cbbEntrada.SelectedIndex = -1;
            cbbSaida.SelectedIndex = -1;
            txtValor.Clear();
        }
    }
}
