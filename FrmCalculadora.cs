using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORAJOSE
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorUno = Convert.ToDouble(TxtPrimerValor.Text);
            double valorDos = Convert.ToDouble(TxtSegundaValor.Text);
            double resultado = valorUno + valorDos;

            TxtResultado.Text = resultado.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrimerValor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtPrimerValor.Clear();  //para limpiar los cuadros de textos
            TxtSegundaValor.Clear();
            TxtResultado.Clear();

            TxtPrimerValor.Focus();  //para devolver el curso al primer cuadro de entrada de texto
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valorUno = Convert.ToDouble(TxtPrimerValor.Text);
            double valorDos = Convert.ToDouble(TxtSegundaValor.Text);
            double resultado = valorUno * valorDos;

            TxtResultado.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valorUno = Convert.ToDouble(TxtPrimerValor.Text);
            double valorDos = Convert.ToDouble(TxtSegundaValor.Text);
            double resultado = valorUno - valorDos;

            TxtResultado.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valorUno = Convert.ToDouble(TxtPrimerValor.Text);
            double valorDos = Convert.ToDouble(TxtSegundaValor.Text);
            double resultado = valorUno / valorDos;

            TxtResultado.Text = resultado.ToString();
        }
    }
}
