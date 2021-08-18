using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public partial class frmNome : Form
    {
        public frmNome()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string nome, sobrenome, nomecompleto;

            nome = txtNome.Text.Trim();
            sobrenome = txtSobre.Text.Trim();

            TextoClass objTexto = new TextoClass();

            nomecompleto = objTexto.AjuntarNome(nome, sobrenome);

            MessageBox.Show("Nome completo: " + objTexto.DeixarMaiuscula(nomecompleto));
        }
    }
}
