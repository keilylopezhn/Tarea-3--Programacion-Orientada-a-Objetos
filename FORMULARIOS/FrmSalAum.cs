using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Orientada_a_Objetos.FORMULARIOS
{
    public partial class FrmSalAum : Form
    {
        CLASES.SALBAUMEN sal = new CLASES.SALBAUMEN();
        public FrmSalAum()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtAum.Text);
            double r = Convert.ToDouble(TxtPrec.Text);

            TxtSal.Text = sal.aumento(n, r).ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtAum.Clear();
            TxtPrec.Clear();
            TxtSal.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtAum_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
