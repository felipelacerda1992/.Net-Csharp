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
    public partial class exLista2 : Form
    {
        public exLista2()
        {
            InitializeComponent();
        }

        List<string> lsNome = new List<string>();
        List<Decimal> lsPeso = new List<Decimal>();
        List<Decimal> lsAlt = new List<Decimal>();
        List<Decimal> lsImc = new List<Decimal>();

        private void Button1_Click(object sender, EventArgs e)
        {
            AddIMC();
            AddNome();
            CarregaListas();

           
        }

        private Decimal CalculaIMC (Decimal p, Decimal a)
        {
            Decimal imc;
                
            imc = p / (a * a);

            return imc;
        }

        private void AddIMC()
        {
            Decimal peso = Convert.ToDecimal(txtPeso.Text);
            Decimal altura = Convert.ToDecimal(txtAltura.Text);
            Decimal imc;
            imc = CalculaIMC(peso, altura);

            lsImc.Add(imc);
            lsPeso.Add(peso);
            lsAlt.Add(altura);

        }

        private void AddNome()
        {
             string nome = txtNome.Text;
            lsNome.Add(nome);
        }

        private void CarregaListas()
        {
            ltbIMC.DataSource = null;
            ltbIMC.DataSource = lsImc;

            ltbPeso.DataSource = null;
            ltbPeso.DataSource = lsPeso;

            ltbAltura.DataSource = null;
            ltbAltura.DataSource = lsAlt;

            ltbNome.DataSource = null;
            ltbNome.DataSource = lsNome;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ltbAltura.DataSource = null;
            ltbIMC.DataSource = null;
            ltbNome.DataSource = null;
            ltbPeso.DataSource = null;

            ltbAltura.Items.Clear();
            lsAlt.Clear();
            ltbIMC.Items.Clear();
            lsImc.Clear();
            ltbNome.Items.Clear();
            lsNome.Clear();
            ltbPeso.Items.Clear();
            lsPeso.Clear();
        }
    }
}
