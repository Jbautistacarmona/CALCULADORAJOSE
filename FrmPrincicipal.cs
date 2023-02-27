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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz presionado aceptar");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz presionado cancelar");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmSegunda frmsegunda = new FrmSegunda();
            frmsegunda.Show();
        }
    }
}
