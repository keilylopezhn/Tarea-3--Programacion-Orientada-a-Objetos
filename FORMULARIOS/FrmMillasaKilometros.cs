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
    public partial class FrmMillasaKilometros : Form
    {
        CLASES.MIKILO mk = new CLASES.MIKILO();
       
        public FrmMillasaKilometros()
        {
            InitializeComponent();
        }

        private void BtnConv_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(TxtMilla.Text);

            TxtRes.Text = mk.mikilo(n).ToString();
           
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtMilla.Clear();
            TxtRes.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
