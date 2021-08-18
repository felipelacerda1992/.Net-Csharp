using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividades
{
    public partial class exLista1 : Form
    {
        public exLista1()
        {
            InitializeComponent();
        }

        List<int> par = new List<int>();
        List<int> impar = new List<int>();
        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int n;

            n = Convert.ToInt32(txtN.Text);

            AdicionarNumero(n);

            lsbPar.DataSource = null;
            lsbPar.DataSource = par;


            lsbImpar.DataSource = null;
            lsbImpar.DataSource = impar;
            

            
        }

        private void AdicionarNumero(int nro)
        {
            int np = nro;
            int ni = nro;
            if (np%2 == 0)
            {
                
                par.Add(np);
                
            }
            else
            {
                impar.Add(ni);
            }

        }

        private void Limparls()
        {
            lsbPar.DataSource = null;
            lsbImpar.DataSource = null;

            lsbPar.Items.Clear();
            par.Clear();
            lsbImpar.Items.Clear();
            impar.Clear();
            txtN.Clear();
        }

        private void Btnlimpar_Click(object sender, EventArgs e)
        {
            Limparls();
        }
    }
}
