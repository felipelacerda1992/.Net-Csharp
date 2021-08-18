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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        List<int> lstNumeros = new List<int>();


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int n;

            n = Convert.ToInt32(txtNumero);

            AdicionarNumero(n);
            CarregarList();
            LimparCampos();

        }

        private void AdicionarNumero(int n)
        {
            lstNumeros.Add(n);
        }

        private void CarregarList()
        {
            lbNumeros.DataSource = null;
            lbNumeros.DataSource = lstNumeros;
        }

        private void LimparCampos()
        {
            txtNumero.Clear();
        }
    }
}
