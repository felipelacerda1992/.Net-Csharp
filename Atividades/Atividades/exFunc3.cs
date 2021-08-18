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
    public partial class exFunc3 : Form
    {
        public exFunc3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Double salario = Convert.ToDouble(txtSal.Text);
            Double p2 = Calcula2(salario);
            Double p4 = Calcula4(salario);
            Double p6 = Calcula6(salario);
            Double p8 = Calcula8(salario);

            txtsoma.Text = Convert.ToString(CalculaP(p2, p4, p6, p8));

            txtTotal.Text = Convert.ToString(CalculaT(p2, p4, p6, p8, salario));
        }

        public Double Calcula2(Double sal)
        {
            Double porc2;

            porc2 = sal * 0.02;

            return porc2;
        }

        public Double Calcula4(Double sal)
        {
            Double porc4 = sal * 0.04;

            return porc4;
        }

        public Double Calcula6(Double sal)
        {
            Double porc6;

            porc6 = sal * 0.06;

            return porc6;

        }

        public Double Calcula8(Double sal)
        {
            Double porc8 = sal * 0.08;

            return porc8;
        }

        public Double CalculaP(Double por2, Double por4, Double por6, Double por8)
        {
            Double soma;

            soma = por2 + por4 + por6 + por8;

            return soma;

        }

        public Double CalculaT(Double por2, Double por4, Double por6, Double por8, Double sal)
        {
            Double somaT;

            somaT = por2 + por4 + por6 + por8 + sal;

            return somaT;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string limparp = txtsoma.Text;
            //txtSal.Clear();
            txtSal.Text = LimparC(txtSal.Text);

            txtsoma.Text = LimparC(limparp);

            txtTotal.Text = LimparC(txtTotal.Text);
        }

        private string LimparC(string l)
        {
            l = "";
           

            return l;
        }
    }
}
