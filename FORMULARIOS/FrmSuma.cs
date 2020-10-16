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
    public partial class FrmSuma : Form
    {
        CLASES.SUMARIO  s = new CLASES.SUMARIO ();


        public FrmSuma()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtValorPrim.Clear();
            TxtValorDos.Clear();
            TxtValorTres.Clear();
            TxtTotal.Clear();

        }

        private void FrmSuma_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
             double n = Convert.ToDouble(TxtValorPrim.Text);
             double r = Convert.ToDouble(TxtValorDos.Text);
            double o = Convert.ToDouble(TxtValorTres.Text);
                TxtTotal.Text = s.suma(n,r,o).ToString();

        }
    }
}
