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
    public partial class exFunc2 : Form
    {
        public exFunc2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Double c = Convert.ToDouble(txtTempC.Text);
            Double f = CalcTemp(c);

            lblTemp.Text = "Temperatura em Fahrenheit: " + Convert.ToString(f);
            lblTemp.Visible = true;
        }

        private Double CalcTemp(Double celsius)
        {
            Double far;

            far = (9 * celsius + 160) / 5;

            return far;
        }
    }
}
