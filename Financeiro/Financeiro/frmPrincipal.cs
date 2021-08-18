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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void GerenciarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.ShowDialog();
        }

        private void GerenciarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConta frm = new frmConta();
            frm.ShowDialog();
        }

        private void LançarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimento frm = new frmMovimento();
            frm.ShowDialog();
        }

        private void GerenciarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa();
            frm.ShowDialog();
        }

        private void GerenciarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanco frm = new frmBanco();
            frm.ShowDialog();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarMovimento frm = new frmConsultarMovimento();
            frm.ShowDialog();
        }
    }
}
