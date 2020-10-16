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
    public partial class FrmCubo : Form
    {
        CLASES.CUBO cUBO = new CLASES.CUBO();
        public FrmCubo()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNum.Clear();
            TxtRes.Clear();
        }

        private void BtnConv_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtNum.Text);

            TxtRes.Text = cUBO.cuadrado(n).ToString();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
