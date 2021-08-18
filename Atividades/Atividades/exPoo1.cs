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
    public partial class exPoo1 : Form
    {
        public exPoo1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int numero1;
            numero1 = Convert.ToInt32(txtn1.Text.Trim());
            int numero2;
            numero2 = Convert.ToInt32(txtn2.Text.Trim());

            VerificarClass verifCl = new VerificarClass();

            MessageBox.Show("Maior número digitado: " + verifCl.VerificarMaior(numero1, numero2));
        }
    }
}
