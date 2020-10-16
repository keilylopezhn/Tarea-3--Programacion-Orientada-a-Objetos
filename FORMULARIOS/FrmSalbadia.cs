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
    public partial class FrmSalbadia : Form
    {
        CLASES.SALARIOENBASEADIAS sal = new CLASES.SALARIOENBASEADIAS();
        public FrmSalbadia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCant.Clear();
            TxtPrec.Clear();
            TxtSal.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtCant.Text);
            double r = Convert.ToDouble(TxtPrec.Text);
           



            TxtSal.Text = sal.promedio(n, r).ToString();
        }

        private void FrmSalbadia_Load(object sender, EventArgs e)
        {

        }
    }
}
