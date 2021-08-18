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
    public partial class exFunc1 : Form
    {
        public exFunc1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Double sal = Convert.ToDouble(txtSal.Text);

            Double a15 = Calcular15(sal);
            Double a18 = Calcular18(sal);
            Double total = TotalAumento(sal);

            txt15.Text = Convert.ToString(a15);
            txt18.Text = Convert.ToString(a18);
            txtTotal.Text = Convert.ToString(total);
        }

        private Double Calcular15(Double salario)
        {
           Double aumento15;

             aumento15 = salario*0.15;

            return aumento15;
        }

        private Double Calcular18(Double salario)
        {
            Double aumento18;

            aumento18 = salario*0.18; 

            return aumento18;
        }

        private Double TotalAumento(Double salario)
        {
            Double aumento = salario*0.15 + salario*0.18;
            return aumento;
        }
    }
}
