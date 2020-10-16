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
    public partial class FrmPromedio : Form
    {
        CLASES.PROMEDIO p = new CLASES.PROMEDIO();
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCal1.Clear();
            TxtCal2.Clear();
            TxtCal3.Clear();
            TxtCal4.Clear();
            TxtProm.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtCal1.Text);
            double r = Convert.ToDouble(TxtCal2.Text);
            double o = Convert.ToDouble(TxtCal3.Text);
            double x = Convert.ToDouble(TxtCal4.Text);



            TxtProm.Text = p.promedio(n, r, o,x ).ToString();

          
        }
    }

}
