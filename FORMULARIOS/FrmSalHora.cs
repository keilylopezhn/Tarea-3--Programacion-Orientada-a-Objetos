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
    public partial class FrmSalHora : Form
    {
        CLASES.SALARIOEXTRA sal = new CLASES.SALARIOEXTRA();
        public FrmSalHora()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCant.Clear();
            TxtPrec.Clear();
            TxtSal.Clear();
            TxtSalba.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtCant.Text);
            double r = Convert.ToDouble(TxtPrec.Text);
            double x = Convert.ToDouble(TxtSalba.Text);




            TxtSal.Text = sal.promedio(n, r, x).ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSalHora_Load(object sender, EventArgs e)
        {

        }
    }
}
