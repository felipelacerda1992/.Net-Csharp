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
    public partial class exPoo2 : Form
    {
        public exPoo2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(txtn.Text);

            VerificarClass verifPar = new VerificarClass();

            MessageBox.Show(verifPar.VerificarParouimpar(numero) + numero);
        }
    }
}
